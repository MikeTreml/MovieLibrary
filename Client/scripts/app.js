getMoviesList();

/* When the user clicks on the button, 
toggle between hiding and showing the dropdown content */
function myFunction() {
    document.getElementById("myDropdown").classList.toggle("show");     // Add :active modifier to button while dropdown is visible
  }
  
  // Close the dropdown if the user clicks outside of it
  window.onclick = function(event) {
    if (!event.target.matches('.dropbtn')) {
      var dropdownForm = document.getElementsByClassName("dropdown-content");
        if (dropdownForm.contains('show')) {
          dropdownForm.remove('show');
        }
      }
    }
  
//Grabs database entries with GET and pass the data to LayoutMovies
function getMoviesList(){
        $.ajax({
            type: "GET",
            url: "https://localhost:44325/api/movie/",
            dataType:'json',
            success: function( data, textStatus, jQxhr ){
                LayoutMovies(data);
                console.log( "Get Done without error" );
            },
            error: function( jqXhr, textStatus, errorThrown ){
                console.log( errorThrown );
            }
        }).done(function(){ console.log( "Get Done" );
    });
} 
//Search database with GET for any part of a word.
function searchMovies(search){

    $.ajax({
        type: "GET",
        url: "https://localhost:44325/api/movie/search/"+search,
        dataType:'json',
        success: function( data, textStatus, jQxhr ){
            LayoutMovies(data);
            console.log( "search without error" );
        },
        error: function( jqXhr, textStatus, errorThrown ){
            console.log( errorThrown );
        }
    }).done(function(){ console.log( "search Done" );
});
    
} 
//Grabs one movie by ID with GET
function loadMovieForm(id){
    $.ajax({
        type: "GET",
        url: "https://localhost:44325/api/movie/" + id,
            dataType:'json',
            success: function( data, textStatus, jQxhr ){
                editMovieForm(data);
                // processEditForm();
                //LayoutMovies(data);
                console.log( "grab for edit without error" );
                // LayoutMovies(data);
                console.log(id);
            },
            error: function( jqXhr, textStatus, errorThrown ){
                console.log( errorThrown );
            }
    }).done(function(){ console.log( "grab for edit Done" );
});
    getMoviesList(); 
}
//Create a String with all the Data entries to be printed to the html
function LayoutMovies(data){
    let layout = `<table><tbody id="movieData"><tr><th>Title</th><th>Director</th><th hidden>Genre</th><th hidden>ImageURL</th><th hidden>Summary</th><th hidden>Year</th><th hidden>Actors</th><th hidden>Rating</th><th>Edit</th><th>Delete</th></tr>`;
    
    for(let i = 0; i < data.length; i++){
        layout +=` <tr onmouseover="mOver(this)" onmouseout="mOut(this)"><td>${data[i].title}</td><td hidden>${data[i].director}</td><td>${data[i].genre}</td><td hidden>${data[i].imageURL}</td><td hidden>${data[i].summary}</td><td hidden>${data[i].year}</td><td hidden>${data[i].actors}</td><td hidden>${data[i].rating}</td><td><button class="btn" onclick="loadMovieForm(${data[i].movieId})">Edit</button></td><td><button class="btn" onclick="confirmDelete(${data[i].movieId})"><i class="fas fa-trash-alt"></i></button></td></tr>`;
    }
    layout +=`</tbody></table>`;
        $("#movieDataShell").html(layout);
}


//Asks the user to verify that they wish to delete the movie.
function confirmDelete(id) {
    if (confirm("Are you sure you want to delete this movie?")) {    
      deleteMovie(id);
    } 
}
function deleteMovie(id){
    $.ajax({
        type: "DELETE",
        url: "https://localhost:44325/api/movie/" + id,
        success: function(){
            console.log( "Delete without error" )
            getMoviesList(); 
        },
        error: function( jqXhr, textStatus, errorThrown ){
            console.log( errorThrown );
        }
    }).done(function(){ console.log( "Delete Done" );
});
    
        
}
    


//fills in textbox on the edit form
function editMovieForm (data){
        $("#id-edit").val(data[0].movieId);
        $("#title-edit").val(data[0].title);
        $("#genre-edit").val(data[0].genre);
        $("#director-edit").val(data[0].director);
        $("#genre-edit").val(data[0].genre);
        $("#imageurl-edit").val(data[0].imageurl);
        $("#summary-edit").val(data[0].summary);
        $("#year-edit").val(data[0].year);
        $("#actors-edit").val(data[0].actors);
        $("#rating-edit").val(data[0].rating);
 }

//UPDATE use PUT to update current entries
function processEditForm( e ){
    var dict = {
        MovieId : parseInt(this["movieId"].value),
        Title : this["title"].value,
        Genre : this["genre"].value,
        Director : this["director"].value,
        Genre : this["genre"].value,
        ImageURL : this["imageurl"].value,
        Summary : this["summary"].value,
        Year : this["year"].value,
        Actors : this["actors"].value,
        Rating : this["rating"].value

    };
    $.ajax({
        url: 'https://localhost:44325/api/movie',
        dataType: 'json',
        type: 'put',
        contentType: 'application/json',
        data: JSON.stringify(dict),
        success: function(data, textStatus, jQxhr ){
            //$('#response pre').html( data );
            console.log( "Update done without errors" );
            console.log( data);
        },
        error: function( jqXhr, textStatus, errorThrown ){
            console.log( errorThrown );
            console.log( "Update error" );
        }
    }).done(function(){ console.log( "Update done" );
});
    getMoviesList();
    document.getElementById("edit-form").reset();
    e.preventDefault();
    console.log( "Update refresh" );
  
}


//CREATE NEW use POST for new entries
function processForm( e ){
    var dict = {
        Title : this["title"].value,
        Genre : this["genre"].value,
        Director : this["director"].value,
        Genre : this["genre"].value,
        ImageURL : this["imageurl"].value,
        Summary : this["summary"].value,
        Year : this["year"].value,
        Actors : this["actors"].value,
        Rating : this["rating"].value

    };
    $.ajax({
        url: 'https://localhost:44325/api/movie',
        dataType: 'json',
        type: 'post',
        contentType: 'application/json',
        data: JSON.stringify(dict),
        success: function( data, textStatus, jQxhr ){
            
            console.log( "Create new done without error" );
        },
        error: function( jqXhr, textStatus, errorThrown ){
            console.log( errorThrown );
        }
    }).done(function(){ console.log( "Create new done" );
});
    e.preventDefault();
    getMoviesList(); 
}

function processFormXX( e ){
    var dict = {
        Title : this["title"].value,
        Genre : this["genre"].value,
        Director : this["director"].value,
        Genre : this["genre"].value,
        ImageURL : this["imageurl"].value,
        Summary : this["summary"].value,
        Year : this["year"].value,
        Actors : this["actors"].value,
        Rating : this["rating"].value

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
    getMoviesList(); 
}

$('#edit-form').submit( processEditForm );
$('#create-form').submit( processForm );
$('#search-data').submit( searchMovies );
// $('tbody tr').mouseover( showDetails );

//Grabs one movie by ID with GET to show in DETAILS
// function loadDetails(id){
//     $.ajax({
//         type: "GET",
//         url: "https://localhost:44325/api/movie/" + id,
//             dataType:'json',
//             success: function( data, textStatus, jQxhr ){
//                 showDetails(data);
//                 // processEditForm();
//                 //LayoutMovies(data);
//                 console.log( "grab for edit without error" );
//                 // LayoutMovies(data);
//                 console.log(id);
//             },
//             error: function( jqXhr, textStatus, errorThrown ){
//                 console.log( errorThrown );
//             }
//     }).done(function(){ console.log( "grab for edit Done" );
// });
//     getMoviesList(); 
// }
// function showDeetsMouseOver
// document.
function mOver(obj){
    alert( $(obj).children().closest("tr").html());
        $("#details__genre-grid").text("<td>${data[i].title}</td>");
        $("#details__title-grid").html(`<p>Test paragraph</p>`);
        $("#details__director-grid").html(`<p>${obj.item(0)}</p>`);
        $("#details__poster-grid").html(`<img src="https://i.pinimg.com/originals/28/1d/03/281d03d7e0fae42cf27ebf513c00c6eb.jpg">`);
        // $("#details__summary-grid").html(`<td>${data[i].title}</td>`);
        // $("#details__year-grid").html(`<td>${data[i].title}</td>`);
        // $("#details__actors-grid").html(`<td>${data[i].title}</td>`);
        // $("#details__rating-grid").html(`<td>${data[i].title}</td>`);
};
function mOut(obj){

}


