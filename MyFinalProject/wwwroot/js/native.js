

let baskets = document.querySelectorAll(".purchaseBasket .fa-shopping-basket ")
console.log(baskets)
for (let basket of baskets) {
    basket.addEventListener("click", function() {
        this.firstChild.firstChild.classList.remove("d-none")
        this.nextElementSibling.classList.add("d-none")

    })
}