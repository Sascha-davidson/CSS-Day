const customSelect = document.querySelector(".custom-select");
const selectBtn = document.querySelector(".select-button");

const selectedValue = document.querySelector(".selected-value");
const optionsList = document.querySelectorAll(".select-dropdown li");

// add click event to select button
selectBtn.addEventListener("click", () => {
    // add/remove active class on the container element
    customSelect.classList.toggle("active");
    // update the aria-expanded attribute based on the current state
    selectBtn.setAttribute(
        "aria-expanded",
        selectBtn.getAttribute("aria-expanded") === "true" ? "false" : "true"
    );
});

optionsList.forEach((option) => {
    function handler(e) {
        // Click Events
        if (e.type === "click" && e.clientX !== 0 && e.clientY !== 0) {
            selectedValue.textContent = this.children[1].textContent;
            customSelect.classList.remove("active");
        }
        // Key Events
        if (e.key === "Enter") {
            selectedValue.textContent = this.textContent;
            customSelect.classList.remove("active");
        }
    }

    option.addEventListener("keyup", handler);
    option.addEventListener("click", handler);
});


window.addEventListener('click', function (event) {
    // Check if the click target is the dialog backdrop
    if (event.target === document.getElementById('myDialog')) {
        closeDialog();
    }
});

// Function to open the dialog
function openDialog() {
    var dialog = document.getElementById('myDialog');
    dialog.showModal();
}

// Function to close the dialog with animation
function closeDialog() {
    var dialog = document.getElementById('myDialog');
    
    // Add a class to trigger the closing animation
    dialog.classList.add('closing');

    // Listen for animation end event
    dialog.addEventListener('animationend', function () {
        // After animation completes, close the dialog
        dialog.close();

        // Remove the closing class to reset for next time
        dialog.classList.remove('closing');
    }, { once: true }); // Use { once: true } to automatically remove the event listener after it's fired once
}