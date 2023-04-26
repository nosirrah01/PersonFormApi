const form = document.querySelector('form');
form.addEventListener('submit', function (event) {
    event.preventDefault();

    const name = document.querySelector('#name').value;
    const age = document.querySelector('#age').value;
    const sex = document.querySelector('input[name="sex"]:checked');

    if (!name || !age || !sex) {
        alert('Please fill out all the fields!');
    } else {
        form.submit();
    }
});