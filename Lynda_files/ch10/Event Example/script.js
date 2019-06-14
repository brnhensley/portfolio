var headline = document.getElementById("mainHeading");
var boobs = document.getElementById("subHeadline");
var smaller = document.getElementById("lastHeadline");
var text = document.getElementById("text");

headline.onclick = function(){
  headline.innerHTML = "You clicked the headline!";
};

boobs.onclick = function(){
  boobs.innerHTML = "You clicked the boobs!";
};

smaller.onclick = function(){
  smaller.innerHTML = "You clicked the smaller boobs.... Why?";
};

text.onclick = function(){
  text.innerHTML = "You've clicked everything now!";
};
