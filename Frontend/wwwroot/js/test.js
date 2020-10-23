function kopyalama(element) {
    var alan = element.parentElement.querySelector('a').innerHTML;
    var textAlani = document.createElement('TEXTAREA');
    textAlani.value = alan;
    document.body.appendChild(textAlani);
    textAlani.select();
    document.execCommand('copy');
    textAlani.style.display = 'none';
}