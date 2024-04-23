let DefaultSelect = document.querySelector(".default-select")
let CustomSelect = document.querySelector(".Custom-select")

if (typeof performAction === 'function') {
    // JavaScript is active, so perform the action
    DefaultSelect.setAttribute('hidden', '');
    CustomSelect.removeAttribute('hidden');
} else {
    // JavaScript is not active (unlikely scenario), do nothing
    // Alternatively, you can provide fallback content or display a message
    console.log("JavaScript is not active.");
}