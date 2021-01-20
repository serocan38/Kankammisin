function kopyalama(element) {
    var alan = element.parentElement.querySelector('a').innerHTML;
    var textAlani = document.createElement('TEXTAREA');
    textAlani.value = alan;
    document.body.appendChild(textAlani);
    textAlani.select();
    document.execCommand('copy');
    textAlani.style.display = 'none';
}
$(document).ready(function () {
    $("table").dataTable({
        "language": {
            "url": "//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Turkish.json"
        },
        "searching": false,
        "ordering": true,
        "paging": true,
        "pagingType": "full_numbers",
        "pageLength": 10,
        "responsive": false,
        "columnDefs": [{
            "targets": [1,3,4],
            "orderable": false
        }]
    });
});

