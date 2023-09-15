window.SetFocusToElement = (element) => {
    element.onblur = function () {
        element.className = 'dropdown-menu language-dropdown-menu hide';
    }
};