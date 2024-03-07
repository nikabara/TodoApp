let remove_toggle = document.querySelector(".remove-todo");
var special_utilities = document.querySelectorAll(".special-utilities");


let count = 0;
remove_toggle.addEventListener("click", () => {
    for (var i = 0; i < special_utilities.length; i++) {
        if (count % 2 == 0) {
            special_utilities[i].classList.add("toggled");
        }
        else {
            special_utilities[i].classList.remove("toggled");
        }
    }
    count++;
});