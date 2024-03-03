function displayData(page) {
    $("#data-table tbody").empty();
    var startIndex = (page - 1) * itemsPerPage;
    var endIndex = startIndex + itemsPerPage;
    var keys = Object.keys(data);
    var pageKeys = keys.slice(startIndex, endIndex);
    // Отобразить данные на странице
    pageKeys.forEach(function (dateKey) {
        var rowData = data[dateKey];
        var row = "<tr>";
        Object.keys(rowData).forEach(function (key) {
            if (key === Object.keys(rowData)[0]) {
                row += "<td>" + dateKey + "</td>";
            }
            row += "<td>" + rowData[key] + "</td>";
        });
        row += "</tr>";
        $("#data-table tbody").append(row);
    });
    var totalPages = Math.ceil(Object.keys(data).length / itemsPerPage);
    $("#page-number").text("Страница " + page);
    if (currentPage > 1) {
        $("#prev-btn").show();
    }
    else {
        $("#prev-btn").hide();
    }
    if (currentPage < totalPages) {
        $("#next-btn").show();
    }
    else {
        $("#next-btn").hide();
    }
}