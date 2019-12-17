$(document).ready(function ()
{
    //click تنفع
    $(".choose").change(function ()
    {
        if($(this).val()=="BMW")
        {
            $(".selected").empty(); //علشان نفضي السليكت من المحتوى بتاعها عند اختيار اوبشن جديد
            $(".selected").prepend("<option>116i</option><option>520i</option><option>X3</option>")
        }

        else if ($(this).val() == "Lada")
        {
            $(".selected").empty();
            $(".selected").prepend("<option>Lada</option><option>Lada</option><option>Lada</option>")
        }

        else if ($(this).val() == "Borch")
        {
            $(".selected").empty();
            $(".selected").prepend("<option>Borch</option><option>Borch</option><option>Borch</option>")
        }

        else if ($(this).val() == "Chevorle")
        {
            $(".selected").empty();
            $(".selected").prepend("<option> Aveo</option><option>Optra</option><option></option>")
        }

     
        else if ($(this).val() == "Jeep") {
            $(".selected").empty();
            $(".selected").prepend("<option>Jeep</option><option>Jeep</option><option>Jeep</option>")
        }

        else if ($(this).val() == "Honda") {
            $(".selected").empty();
            $(".selected").prepend("<option>Honda</option><option>Honda</option><option>Honda</option>")
        }

        else if ($(this).val() == "Hyundai") {
            $(".selected").empty();
            $(".selected").prepend("<option>i10</option><option>Verna</option><option>I30</option>")
        }

        else if ($(this).val() == "Peugeot") {
            $(".selected").empty();
            $(".selected").prepend("<option>5008</option><option>3008</option><option>508</option>")
        }

        else if ($(this).val() == "Toyota") {
            $(".selected").empty();
            $(".selected").prepend("<option>Yaris</option><option>Toyota</option><option>Toyota</option>")
        }

        else if ($(this).val() == "KIA") {
            $(".selected").empty();
            $(".selected").prepend("<option>Picanto</option><option>Cerato</option><option>KIA</option>")
        }
     
       
    });
    

    $(".right img,.left img").animate({height:'600px',width:'60px;'},1000);
    
});




    
