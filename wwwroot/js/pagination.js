$(document).ready(function () {
    displayData(currentPage);

    $("#prev-btn").click(function () {
        if (currentPage > 1) {
            currentPage--;
            displayData(currentPage);
        }
    });

    $("#next-btn").click(function () {
        var totalPages = Math.ceil(Object.keys(data).length / itemsPerPage);
        if (currentPage < totalPages) {
            currentPage++;
            displayData(currentPage);
        }
    });

    $(".sort-btn").click(function () {
        var sortOrder = $(this).data("order");

        // Изменяем направление сортировки
        if (sortOrder === "asc") {
            $(this).data("order", "desc");
            $(this).html("&#9660;"); // Изменяем иконку на стрелку вниз
        } else {
            $(this).data("order", "asc");
            $(this).html("&#9650;"); // Изменяем иконку на стрелку вверх
        }

        sortDataByDate(sortOrder)
    });
});