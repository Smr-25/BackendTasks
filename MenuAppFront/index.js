const categoryList = document.getElementsByClassName("category-list")[0];
function getCategories() {
    fetch("http://localhost:5075/api/Categories")
        .then(response => response.json())
        .then(data => {
            data.forEach(
                category => {
                    const button = document.createElement("button");
                    button.className = "category-btn";
                    button.innerText = category.name;
                    button.setAttribute("data-category", category.id);
                    categoryList.appendChild(button);
                }
            )
        })
}

getCategories();