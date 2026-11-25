// Ask for confirmation before submitting a form marked with data-confirm.
document.addEventListener("submit", function (event) {
    const form = event.target;
    if (!(form instanceof HTMLFormElement)) return;

    const confirmationMessage = form.dataset.confirm;
    if (confirmationMessage && !window.confirm(confirmationMessage)) {
        event.preventDefault();
    }
});

// Mobile Sidebar toggle logic
document.addEventListener("DOMContentLoaded", function () {
    const sidebarToggleBtn = document.getElementById("sidebarToggleBtn");
    const sidebarCloseBtn = document.getElementById("sidebarCloseBtn");
    const sidebarBackdrop = document.getElementById("sidebarBackdrop");
    const appSidebar = document.getElementById("appSidebar");

    function openSidebar() {
        if (appSidebar) appSidebar.classList.add("open");
        if (sidebarBackdrop) sidebarBackdrop.classList.add("show");
    }

    function closeSidebar() {
        if (appSidebar) appSidebar.classList.remove("open");
        if (sidebarBackdrop) sidebarBackdrop.classList.remove("show");
    }

    if (sidebarToggleBtn) {
        sidebarToggleBtn.addEventListener("click", openSidebar);
    }
    if (sidebarCloseBtn) {
        sidebarCloseBtn.addEventListener("click", closeSidebar);
    }
    if (sidebarBackdrop) {
        sidebarBackdrop.addEventListener("click", closeSidebar);
    }
});
