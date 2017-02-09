jQuery(document).ready(function () {
    jQuery('.post').addClass("not-visible").viewportChecker({
        classToAdd: 'visible animated bounceInUp',
        offset: 100
    });
});