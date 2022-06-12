
    $(document).ready(function () {

        $('#software').click(function () {
            $('#softwareDiv').show();
            $('#humanDiv').hide();
            $('#businessDiv').hide();
        });

    $('#human').click(function () {
        $('#humanDiv').show();
    $('#softwareDiv').hide();
    $('#businessDiv').hide();
        });

    $('#business').click(function (){
        $('#businessDiv').show();
    $('#softwareDiv').hide();
    $('#humanDiv').hide();
            

        });

    });




    $('.service-catergory li').on('click', function () {
        $('li').removeClass('active');
    $(this).addClass('active');

    });