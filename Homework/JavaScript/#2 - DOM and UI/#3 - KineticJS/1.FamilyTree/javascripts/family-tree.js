// Using Kinetic create a family tree

var stage = new Kinetic.Stage({
	container: 'kinetic-container',
	width: 1000,
	height: 500
});

var layer = new Kinetic.Layer();

// Grandfather Family Tree
var grandfather = new Kinetic.Line({
	points: [ 550, 80,
			  700, 80,
			  700, 120,
			  550, 120 ],
	stroke: '#85bd1a',
	strokeWidth: '4',
	fill: 'transparent',
	closed: true,
	tension: 0.2
});

var lineGrandFatherToMother = new Kinetic.Line({
	points: [ 620, 125,
			  650, 160,
			  750, 200,
			  750, 210 ],
	stroke: '#85bd1a',
	strokeWidth: '4',
	tension: 0.5
});

var grandfatherText = new Kinetic.Text({
	x: 550,
	y: 90,
	width: 150,
	text: 'Todor Stamatov',
	align: 'center',
	fontSize: 20,
    fontFamily: 'Calibri',
    fill: '#1b1b1b'
});

// Grandmother Family Tree
var grandmother = new Kinetic.Line({
	points: [ 800, 80,
			  950, 80,
			  950, 120,
			  800, 120 ],
	stroke: '#85bd1a',
	strokeWidth: '4',
	fill: 'transparent',
	closed: true,
	tension: 0.4
});

var lineGrandMotherToMother = new Kinetic.Line({
	points: [ 890, 130,
			  860, 160,
			  750, 200,
			  750, 210 ],
	stroke: '#85bd1a',
	strokeWidth: '4',
	tension: 0.5
});

var grandmotherText = new Kinetic.Text({
	x: 800,
	y: 90,
	width: 150,
	text: 'Petra Stamatova',
	align: 'center',
	fontSize: 20,
    fontFamily: 'Calibri',
    fill: '#1b1b1b'
});

// Father Family Tree
var father = new Kinetic.Line({
	points: [ 410, 217,
			  560, 217,
			  560, 257,
			  410, 257 ],
  	stroke: '#85bd1a',
  	strokeWidth: '4',
  	fill: 'transparent',
	closed: true,
	tension: 0.2
});

var lineFatherToChildrenBoy = new Kinetic.Line({
	points: [ 480, 260,
			  510, 290,
			  616, 336,
			  616, 346 ],
	stroke: '#85bd1a',
	strokeWidth: '4',
	tension: 0.5
});

var fatherText = new Kinetic.Text({
	x: 410,
	y: 225,
	width: 150,
	text: 'Georgi Petrov',
	align: 'center',
	fontSize: 20,
    fontFamily: 'Calibri',
    fill: '#1b1b1b'
});

// Mother Family Tree
var mother = new Kinetic.Line({
	points: [ 675, 217,
			  825, 217,
			  825, 257,
			  675, 257 ],
  	stroke: '#85bd1a',
  	strokeWidth: '4',
  	fill: 'transparent',
	closed: true,
	tension: 0.4
});

var lineMotherToChildrenBoy = new Kinetic.Line({
	points: [ 755, 266,
			  735, 296,
			  618, 336,
			  618, 346 ],
	stroke: '#85bd1a',
	strokeWidth: '4',
	tension: 0.5
});

var lineMotherToChildrenGirl = new Kinetic.Line({
	points: [ 755, 266,
			  785, 296,
			  885, 336,
			  900, 346 ],
	stroke: '#85bd1a',
	strokeWidth: '4',
	tension: 0.5
});

var motherText = new Kinetic.Text({
	x: 675,
	y: 225,
	width: 150,
	text: 'Maria Petrova',
	align: 'center',
	fontSize: 20,
    fontFamily: 'Calibri',
    fill: '#1b1b1b'
});

// Children Boy Family Tree
var childrenBoy = new Kinetic.Line({
	points: [ 542, 350,
			  692, 350,
			  692, 390,
			  542, 390 ],
  	stroke: '#85bd1a',
  	strokeWidth: '4',
  	fill: 'transparent',
	closed: true,
	tension: 0.2
});

var childrenBoyText = new Kinetic.Text({
	x: 542,
	y: 358,
	width: 150,
	text: 'Peter Petrov',
	align: 'center',
	fontSize: 20,
    fontFamily: 'Calibri',
    fill: '#1b1b1b'
});

// Children Girl Family Tree
var childrenGirl = new Kinetic.Line({
	points: [ 800, 350,
			  950, 350,
			  950, 390,
			  800, 390 ],
  	stroke: '#85bd1a',
  	strokeWidth: '4',
  	fill: 'transparent',
	closed: true,
	tension: 0.2
});

var childrenGirlText = new Kinetic.Text({
	x: 800,
	y: 358,
	width: 150,
	text: 'Teodora Petrova',
	align: 'center',
	fontSize: 20,
    fontFamily: 'Calibri',
    fill: '#1b1b1b'
});

layer.add(grandfather);
layer.add(lineGrandFatherToMother);
layer.add(grandfatherText);
layer.add(grandmother);
layer.add(lineGrandMotherToMother);
layer.add(grandmotherText);
layer.add(father);
layer.add(lineFatherToChildrenBoy);
layer.add(fatherText);
layer.add(mother);
layer.add(lineMotherToChildrenBoy);
layer.add(lineMotherToChildrenGirl);
layer.add(motherText);
layer.add(childrenBoy);
layer.add(childrenBoyText);
layer.add(childrenGirl);
layer.add(childrenGirlText);
stage.add(layer);