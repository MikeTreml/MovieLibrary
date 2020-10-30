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
    let layout = `<table><tbody><tr><th>Title</th><th>Director</th><th>Genre</th><th>Edit</th><th>Delete</th></tr>`;
    
    for(let i = 0; i < data.length; i++){
        layout +=` <tr><td>${data[i].title}</td><td>${data[i].director}</td><td>${data[i].genre}</td><td><button onclick="loadMovieForm(${i+1})">Edit</button></td><td><button>Delete</button></td></tr>`;
    }
    layout +=`</tbody></table>`;
        $("#movieData").html(layout);
}

function loadMovieForm(id){
    $.ajax({
        type: "GET",
        url: "https://localhost:44325/api/movie/" + id,
            dataType:'json',
            success: function( data, textStatus, jQxhr ){
                editMovieForm(data);
                // processEditForm();
                LayoutMovies(data);
                console.log(id);
            }
    })
}
function confirmDelete(id) {
    if (confirm("Are you sure you want to delete this movie?")) {    
      deleteMovie(id);
    } 
}
function editMovieForm (data){
    
        $("#title").val(data[0].title);
        $("#genre").val(data[0].genre);
        $("#director").val(data[0].director);
        console.log(data[0].id);
}

// function processEditForm( e ){
//     var dict = {
//         Title : this["title"].value,
//         Genre: this["genre"].value,
//         Director: this["director"].value
//     };

//     $.ajax({
//         url: 'https://localhost:44325/api/movie',
//         dataType: 'json',
//         type: 'put',
//         contentType: 'application/json',
//         data: JSON.stringify(dict),
//         success: function( data, textStatus, jQxhr ){
//             $('#response pre').html( data );
//         },
//         error: function( jqXhr, textStatus, errorThrown ){
//             console.log( errorThrown );
//         }
//     });

//     e.preventDefault();
// }



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


