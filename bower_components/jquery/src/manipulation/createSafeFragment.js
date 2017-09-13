<<<<<<< HEAD
define( [
	"./var/nodeNames"
], function( nodeNames ) {

function createSafeFragment( document ) {
	var list = nodeNames.split( "|" ),
		safeFrag = document.createDocumentFragment();

	if ( safeFrag.createElement ) {
		while ( list.length ) {
			safeFrag.createElement(
				list.pop()
			);
		}
	}
	return safeFrag;
}

return createSafeFragment;
} );
=======
define( [
	"./var/nodeNames"
], function( nodeNames ) {

function createSafeFragment( document ) {
	var list = nodeNames.split( "|" ),
		safeFrag = document.createDocumentFragment();

	if ( safeFrag.createElement ) {
		while ( list.length ) {
			safeFrag.createElement(
				list.pop()
			);
		}
	}
	return safeFrag;
}

return createSafeFragment;
} );
>>>>>>> 1891c8b9f5096b714cb15914533b2cee0e9d567b
