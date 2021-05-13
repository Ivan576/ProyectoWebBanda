var imgDisc1 = document.getElementById('imageDisc1');
var imgDisc2 = document.getElementById('imageDisc2');
var imgDisc3 = document.getElementById('imageDisc3');

var nameSong1 = document.querySelector('#nameSong1');
var nameSong2 = document.querySelector('#nameSong2');
var nameSong3 = document.querySelector('#nameSong3');

var discSong1 = document.querySelector('#discSong1');
var discSong2 = document.querySelector('#discSong2');
var discSong3 = document.querySelector('#discSong3');

var link1;
var link2;
var link3;

// Espera a que cargue la pagina
document.addEventListener(
    'DOMContentLoaded', function () {
        console.log("Estamos en vivo");
        updateSpotifyMostListened();
    }
);

function button1() {
    window.open(link1);
}

function button2() {
    window.open(link2);
}

function button3() {
    window.open(link3);
}

function updateSpotifyMostListened() {
    var queryString = window.location.hash;
    console.log(queryString);
    var urlSplit = queryString.split('&');
    var Auth = urlSplit[0].replace('#access_token=','');
    console.log(Auth);
    fetch("https://api.spotify.com/v1/artists/2c6Ukhn6LPpBqze0ldW3lj/top-tracks?market=ES", {
        headers: {
            Accept: "application/json",
            Authorization: "Bearer " + Auth,
            "Content-Type": "application/json"
        }
    })
        .then(function (response) {
            response.json()
                .then(function (json) {
                    console.log(json);

                    var img = document.createElement("img");
                    img.src = json.tracks[0].album.images[2].url;
                    imgDisc1.appendChild(img);
                    nameSong1.textContent = json.tracks[0].name;
                    discSong1.textContent = json.tracks[0].album.name;
                    link1 = json.tracks[0].external_urls.spotify;

                    var img = document.createElement("img");
                    img.src = json.tracks[1].album.images[2].url;
                    imgDisc2.appendChild(img);
                    nameSong2.textContent = json.tracks[1].name;
                    discSong2.textContent = json.tracks[1].album.name;
                    link2 = json.tracks[1].external_urls.spotify;

                    var img = document.createElement("img");
                    img.src = json.tracks[2].album.images[2].url;
                    imgDisc3.appendChild(img);
                    nameSong3.textContent = json.tracks[2].name;
                    discSong3.textContent = json.tracks[3].album.name;
                    link3 = json.tracks[2].external_urls.spotify;

                })
        })
}