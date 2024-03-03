document.getElementById("show-table-btn").addEventListener("click", function () {
    document.getElementById("data-container").style.display = "block";
    document.getElementById("pagination").style.display = "block";
    displayData(currentPage); // Показать таблицу и загрузить данные
    event.target.blur();
});