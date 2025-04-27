document.addEventListener('DOMContentLoaded', function() {
    const form = document.getElementById('loginForm');
    const passwordInput = document.getElementById('password');
    const confirmPasswordInput = document.getElementById('confirmPassword');

    form.addEventListener('submit', function(event) {
        if (passwordInput.value !== confirmPasswordInput.value) {
            event.preventDefault(); 
            alert('As senhas não coincidem. Por favor, verifique.');
        }
    });
});
