
/*	Marker manager */
var markerManager = Class.create();
Object.extend(markerManager.prototype, {
	_markers: [],
	
	initialize: function(map) {
		this.map = map;
		this._haltRefresh = false;
	},
	
	addMarker: function(m) {
		this._markers.push(m);
		this._resizeBounds(m.getPoint());
	},
	
	onMoveEnd: function() {
		//this.refresh();
	},
	
	onZoomEnd: function() {
		//this.refresh();
	},
	
	clearOverlays: function() {
		this.map.clearOverlays();
		this._markers = [];
	},
	
	refresh: function() {
		if(!this._haltRefresh) {
			this.map.clearOverlays();
			for(var j=0; j<this._markers.length; j++) {
				var m = this._markers[j];
				//if(this.map.getBounds().contains(m.getPoint())) {
					this.map.addOverlay(m);
				//}
			}
		}
	},
	
	resetView: function() {
		this._haltRefresh = true;
		if(this.bounds) {
			var bounds = this.bounds;
			var center = this.bounds.getCenter();
			var zoomLevel = 15;
			this.map.setCenter(center, zoomLevel);
			while(zoomLevel > 0 && !this.map.getBounds().containsBounds(bounds)) {
				zoomLevel--;
				this.map.setCenter(center, zoomLevel);
			}
		}
		this.bounds = null;
		this._haltRefresh = false;
	},
	
	_resizeBounds: function(p) {
		if(!this.bounds) this.bounds = new GLatLngBounds(p, p);
		else if(p) { this.bounds.extend(p); }
	}

});
