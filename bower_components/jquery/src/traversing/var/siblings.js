<<<<<<< HEAD
define( function() {

return function( n, elem ) {
	var matched = [];

	for ( ; n; n = n.nextSibling ) {
		if ( n.nodeType === 1 && n !== elem ) {
			matched.push( n );
		}
	}

	return matched;
};

} );
=======
define( function() {

return function( n, elem ) {
	var matched = [];

	for ( ; n; n = n.nextSibling ) {
		if ( n.nodeType === 1 && n !== elem ) {
			matched.push( n );
		}
	}

	return matched;
};

} );
>>>>>>> 1891c8b9f5096b714cb15914533b2cee0e9d567b
