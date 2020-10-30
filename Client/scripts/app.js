getMovies();


function getMovies(){
        $.ajax({
            type: "GET",
            url: "https://localhost:44325/api/movie/",
            dataType:'json',
            success: function( data, textStatus, jQxhr ){
                LayoutMovies(data);
            }
        });
} 
function LayoutMovies(data){
    let layout = '<table><tbody><tr><th>Title</th><th>Director</th><th>Genre</th></tr>';
    
    for(let i = 0; i < data.length; i++){
        layout +=' <tr><td>'+data[i].title+'</td><td>'+data[i].director+'</td><td>'+data[i].genre+'</td></tr>';
    }
    layout +='</tbody></table>';
        $("#movieData").html(layout);
}
(function($){
    function processForm( e ){
        var dict = {
            Title : this["title"].value,
            Genre: this["genre"].value,
        	Director: this["director"].value
        };

        $.ajax({
            url: 'https://localhost:44325/api/movie',
            dataType: 'json',
            type: 'post',
            contentType: 'application/json',
            data: JSON.stringify(dict),
            success: function( data, textStatus, jQxhr ){
                $('#response pre').html( data );
            },
            error: function( jqXhr, textStatus, errorThrown ){
                console.log( errorThrown );
            }
        });

        e.preventDefault();
    }

    function processFormXX( e ){
        var dict = {
            Title : this["title"].value,
            Genre: this["genre"].value,
        	Director: this["director"].value
        };

        $.ajax({
            url: 'https://localhost:44325/api/movie',
            dataType: 'json',
            type: 'get',
            contentType: 'application/json',
            data: JSON.stringify(dict),
            success: function( data, textStatus, jQxhr ){
                $('#response pre').html( data );
            },
            error: function( jqXhr, textStatus, errorThrown ){
                console.log( errorThrown );
            }
        });

        e.preventDefault();
    }

    $('#create-or-search-form').submit( processForm );
    $('#create-or-search-form').search( processFormXX );
})(jQuery);
