$(document).ready(function () {
    $('#GovernorateId').on('change', function () {
        var governorateId = $(this).val();
        var areaList = $('#AreaId');

        areaList.empty();
        areaList.append('<option></option>');

        if (governorateId !== '') {  // Fix condition check
            $.ajax({
                url: '/Subscribers/GetAreas?GovernorateId=' + governorateId,
                success: function (areas) {  // Corrected 'seccess' to 'success'
                    $.each(areas, function (i, area) {
                        var item = $('<option></option>').attr("value", area.value).text(area.text);  // Fixed creation of option element
                        areaList.append(item);
                    });
                },
                error: function () {
                    ShowErrorMessage();
                }
            });
        }
    });
});
