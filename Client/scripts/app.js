getMovies("dark");

//Grabs database entries with GET and pass the data to LayoutMovies
function getMovies(){
        $.ajax({
            type: "GET",
            url: "https://localhost:44325/api/movie/",
            dataType:'json',
            success: function( data, textStatus, jQxhr ){
                LayoutMovies(data);
            },
            error: function( jqXhr, textStatus, errorThrown ){
                console.log( errorThrown );
            }
        });
} 
//Search database with GET for any part of a word.
function getMovies(search){

    $.ajax({
        type: "GET",
        url: "https://localhost:44325/api/movie/search/"+search,
        dataType:'json',
        success: function( data, textStatus, jQxhr ){
            LayoutMovies(data);
        },
        error: function( jqXhr, textStatus, errorThrown ){
            console.log( errorThrown );
        }
    });
} 
//Grabs one movie by ID with GET
//****In procces create popup*****
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
            },
            error: function( jqXhr, textStatus, errorThrown ){
                console.log( errorThrown );
            }
    })
}
//Create a String with all the Data entries to be printed to the html
function LayoutMovies(data){
    let layout = `<table><tbody><tr><th>Title</th><th>Director</th><th>Genre</th><th>Edit</th><th>Delete</th></tr>`;
    
    for(let i = 0; i < data.length; i++){
        layout +=` <tr><td>${data[i].title}</td><td>${data[i].director}</td><td>${data[i].genre}</td><td><button class="btn" onclick="loadMovieForm(${i+1})">Edit</button></td><td><button class="btn"><span><i class="icon-basic-trashcan-remove">"\e01f"</i><span></button></td></tr>`;
    }
    layout +=`</tbody></table>`;
        $("#movieData").html(layout);
}


//Asks the user to verify that they wish to delete the movie.
function confirmDelete(id) {
    if (confirm("Are you sure you want to delete this movie?")) {    
      deleteMovie(id);
    } 
}

//fills in textbox on the edit form
function editMovieForm (data){
        $("#id-edit").val(data[0].movieId);
        $("#title-edit").val(data[0].title);
        $("#genre-edit").val(data[0].genre);
        $("#director-edit").val(data[0].director);
        console.log(data[0].id);
}

//UPDATE use PUT to update current entries
function processEditForm( e ){
    var dict = {
        MovieId : parseInt(this["movieId"].value),
        Title : this["title"].value,
        Genre: this["genre"].value,
        Director: this["director"].value
    };

    $.ajax({
        url: 'https://localhost:44325/api/movie',
        dataType: 'json',
        type: 'put',
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


//CREATE NEW use POST for new entries
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

$('#edit-form').submit( processEditForm );
$('#create-or-search-form').submit( processForm );
$('#create-or-search-form').search( processFormXX );


