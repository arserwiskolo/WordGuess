$('#nav-toggle').on('click', function(e) {
  $(this).toggleClass('nav-open');
  $('#outer-wrapper').toggleClass('nav-open');
});