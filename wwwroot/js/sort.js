function sortDataByDate(order) {
    var dataArray = Object.keys(data).map(function (date) {
        return { date: date, fields: data[date] };
    });

    // Сортировка объектов по дате
    dataArray.sort(function (a, b) {
        var dateA = new Date(a.date);
        var dateB = new Date(b.date);
        if (order === "asc") {
            return dateA - dateB;
        } else {
            return dateB - dateA;
        }
    });

    data = {};
    dataArray.forEach(function (item) {
        data[item.date] = item.fields;
    });

    displayData(currentPage)
}