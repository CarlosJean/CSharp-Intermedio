const baseUrl = "/bills"
const btnFindCustomer = $("#btnFindCustomer");
const txtPersonalIdentification = $("#txtPersonalIdentification");
const txtCustomerName = $("#txtCustomerName");
const btnAddProducts = $("#btnAddProducts");
const tblProductsList = $("#tblProductsList");
const tblDetails = $("#tblDetails");
const lblSubtotal = $("#lblSubtotal");
const lblTaxes = $("#lblTaxes");
const lblTotal = $("#lblTotal");

$(document).ready(function () {
    localStorage.clear();
});

btnFindCustomer.on("click", function () {

    const personalIdentification = txtPersonalIdentification.val();

    $.ajax({
        url: `${baseUrl}/GetCustomer`,
        type: 'POST',
        data: { personalIdentification },
        success: function (customer) {
            txtCustomerName.val(customer.name);

            let bill = JSON.parse(localStorage.getItem("bill")) ?? {};
            localStorage.setItem("bill", JSON.stringify({ ...bill, customerId: customer.id }));
        }
    });
});

btnAddProducts.on('click', function () {
    $.ajax({
        url: `${baseUrl}/GetProducts`,
        type: 'POST',
        success: function (products) {

            const rows = products.map((product) =>
                `<tr>
                    <td>${product.description}</td>
                    <td>${product.stock}</td>
                    <td>${product.unitPrice}</td>
                    <td><button onClick='addProduct(${product.id})'>Añadir</button></td>
                </tr>`
            )

            tblProductsList.children('tbody').html(rows);
        }
    });
});

function addProduct(productId) {
    $.ajax({
        url: `${baseUrl}/GetProduct`,
        type: 'POST',
        data: { productId },
        success: function (response) {

            const product = { ...response.product, taxes: response.taxes, originalTaxes: response.taxes };

            const bill = JSON.parse(localStorage.getItem("bill")) ?? {};
            let billDetails = bill.details ?? [];

            const existingProductIndex = billDetails.findIndex((element) => product.id == element.id);
            let newQuantity = (billDetails[existingProductIndex]?.quantity ?? 0)

            if (existingProductIndex == -1) {
                newQuantity++;
                billDetails = [
                    ...billDetails,
                    {
                        ...product,
                        quantity: newQuantity,
                        taxes: product.taxes * newQuantity,
                        value: (product.taxes * newQuantity) + (product.unitPrice * newQuantity)
                    }];
            } else {
                newQuantity += (product.stock > billDetails[existingProductIndex]?.quantity);
                billDetails[existingProductIndex] = {
                    ...product,
                    quantity: newQuantity,
                    taxes: product.originalTaxes * newQuantity,
                    value: (product.originalTaxes * newQuantity) + (product.unitPrice * newQuantity)
                };
            }

            localStorage.setItem("bill", JSON.stringify({ ...bill, details: billDetails }));

            refreshBillDetails(billDetails);
            refreshTotals(billDetails);
        }
    });
}

function refreshBillDetails(details) {
    const rows = details.map((product) =>
        `<tr>
            <td>${product.description}</td>
            <td>${product.taxes}</td>
            <td>${product.value}</td>
            <td>
                <input 
                    max= ${product.stock}
                    min= 1 
                    placeholder= "Cantidad" 
                    type= "number" 
                    value= '${product.quantity}'
                    onChange= 'quantityChanges(this, ${product.id}, ${product.stock})' 
                    />
            </td>
            <td>
                <button onClick='removeProduct(${product.id})'>Remover</button>
            </td>
        </tr>`
    )

    tblDetails.children('tbody').html(rows);
}

function refreshTotals(details) {

    const subtotal = details.reduce((accumulator, currentProduct) =>
        accumulator + (currentProduct.value - currentProduct.taxes)
        , 0);

    const taxes = details.reduce((accumulator, currentProduct) =>
        accumulator + currentProduct.taxes
        , 0);

    const total = details.reduce((accumulator, currentProduct) =>
        accumulator + currentProduct.value
        , 0);

    lblSubtotal.text(subtotal);
    lblTaxes.text(taxes);
    lblTotal.text(total);
}

function removeProduct(productId) {

    const bill = JSON.parse(localStorage.getItem("bill")) ?? {};
    let billDetails = bill.details ?? [];

    billDetails = billDetails.filter((product) => product.id != productId);

    localStorage.setItem("bill", JSON.stringify({ ...bill, details: billDetails }));

    refreshBillDetails(billDetails);
    refreshTotals(billDetails);
}

function quantityChanges({ value }, productId, stock) {

    const quantity = (value > stock) ? parseInt(stock) : parseInt(value);

    const bill = JSON.parse(localStorage.getItem("bill")) ?? {};

    let billDetails = bill.details ?? [];

    const existingProductIndex = billDetails.findIndex((element) => element.id == productId);
    const product = billDetails[existingProductIndex]

    billDetails[existingProductIndex] = {
        ...product,
        quantity,
        taxes: product.originalTaxes * quantity,
        value: (product.taxes * quantity) + (product.unitPrice * quantity)
    };

    localStorage.setItem("bill", JSON.stringify({ ...bill, details: billDetails }));

    refreshBillDetails(billDetails);
    refreshTotals(billDetails);
}

function saveBill() {

    const bill = JSON.parse(localStorage.getItem("bill")) ?? {};
    const billDetails = bill.details.map((detail) => (
        {
            id: detail.id,
            quantity: detail.quantity
        }));

    const request = { customerId: bill.customerId, products: billDetails };

    $.ajax({
        url: `${baseUrl}/Save`,
        type: 'POST',
        data: { ...request },
        success: function (response) {
            console.log(response);
        },
        error: function (response) {
            Swal.fire({
                icon: "error",
                title: "Hubo un error",
                text: response.responseJSON.message,
            });
        }
    });
}