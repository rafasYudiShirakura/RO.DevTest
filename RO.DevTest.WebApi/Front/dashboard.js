function showSection(sectionId) {
    const sections = document.querySelectorAll('.section');
    sections.forEach(section => {
        section.classList.remove('active');
    });
    document.getElementById(sectionId).classList.add('active');
}

function editItem(id) {
    alert(`Editar item com ID: ${id}`);
}

function deleteItem(id) {
    if (confirm('Tem certeza que deseja deletar?')) {
        alert(`Deletar item com ID: ${id}`);
    }
}

function showSection(sectionId) {
    const sections = document.querySelectorAll('.section');
    sections.forEach(section => {
        section.classList.remove('active');
    });
    document.getElementById(sectionId).classList.add('active');
}

function createItem(type) {
    if (type === 'produto') {
        openModal('productModal');
    } else if (type === 'usuario') {
        openModal('userModal');
    }
}

function openModal(modalId) {
    document.getElementById(modalId).style.display = 'flex';
}

function closeModal(modalId) {
    document.getElementById(modalId).style.display = 'none';
}

window.onclick = function(event) {
    if (event.target.classList.contains('modal')) {
        event.target.style.display = 'none';
    }
}

document.getElementById('productForm').addEventListener('submit', function(event) {
    event.preventDefault();
    //sem api por enquanto
    alert('Produto salvo com sucesso!');
    closeModal('productModal');
});

document.getElementById('userForm').addEventListener('submit', function(event) {
    event.preventDefault();
    //sem api por enquanto
    alert('Usuário salvo com sucesso!');
    closeModal('userModal');
});

function filterProducts() {
    const sortOption = document.getElementById('product-sort').value;
    const productsBody = document.getElementById('products-body');
    let rows = Array.from(productsBody.rows);

    if (sortOption === 'quantity') {
        rows.sort((a, b) => parseInt(a.cells[2].innerText) - parseInt(b.cells[2].innerText));
    } else if (sortOption === 'alphabetical') {
        rows.sort((a, b) => a.cells[0].innerText.localeCompare(b.cells[0].innerText));
    }

    rows.forEach(row => productsBody.appendChild(row));
}

function filterUsers() {
    const sortOption = document.getElementById('user-sort').value;
    const usersBody = document.getElementById('users-body');
    let rows = Array.from(usersBody.rows);

    if (sortOption === 'alphabetical') {
        rows.sort((a, b) => a.cells[0].innerText.localeCompare(b.cells[0].innerText));
    }

    rows.forEach(row => usersBody.appendChild(row));
}
