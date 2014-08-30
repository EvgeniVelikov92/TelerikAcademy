// Draw the following graphics using canvas:

var canvas = document.getElementById('the-canvas'),
	house = canvas.getContext('2d'),
	bike = canvas.getContext('2d'),
	snowmanHead = canvas.getContext('2d');

house.lineWidth = '3';
bike.lineWidth = '3';
snowmanHead.lineWidth = '3';

//-------------------------------------- Canvas House --------------------------------------//

// Body House
house.fillStyle = '#975b5b';
house.strokeStyle = 'black';

house.fillRect(900, 300, 250, 200);
house.strokeRect(900, 300, 250, 200);

// Windows House
house.fillStyle = 'black';

// Top Left Window House
house.fillRect(910, 325, 50, 30);
house.fillRect(961, 325, 50, 30);
house.fillRect(910, 356, 50, 30);
house.fillRect(961, 356, 50, 30);

// Top Right Window House
house.fillRect(1040, 325, 50, 30);
house.fillRect(1091, 325, 50, 30);
house.fillRect(1040, 356, 50, 30);
house.fillRect(1091, 356, 50, 30);

// Lower Right Window House
house.fillRect(1040, 413, 50, 30);
house.fillRect(1091, 413, 50, 30);
house.fillRect(1040, 444, 50, 30);
house.fillRect(1091, 444, 50, 30);

// Roof House 
house.fillStyle = '#975b5b';
house.moveTo(900, 299);
house.lineTo(1025, 140);
house.lineTo(1150, 300);
house.closePath();

// Door House 
house.moveTo(925, 500);
house.lineTo(925, 425);
house.closePath;

house.moveTo(960, 500);
house.lineTo(960, 406);
house.closePath();

house.moveTo(995, 500);
house.lineTo(995, 425);
house.closePath();

house.moveTo(925, 425);
house.quadraticCurveTo(960, 390, 995, 425);

house.fill();
house.stroke();
house.beginPath();
house.arc(950, 470, 3, 0, 360 * Math.PI / 180);

house.stroke();
house.beginPath();
house.arc(970, 470, 3, 0, 360 * Math.PI / 180);

// Chimney House
house.moveTo(1080, 260);
house.lineTo(1080, 180);
house.lineTo(1105, 180);
house.lineTo(1105, 260);

house.fill();
house.stroke();
house.beginPath();
house.save();
house.scale(1, 0.3);
house.arc(1093, 600, 12, 0, 360 * Math.PI / 180);
house.restore();

house.fill();
house.stroke();

//-------------------------------------- Canvas Bike --------------------------------------//
bike.fillStyle = '#90cad7';
bike.strokeStyle = '#358092';

bike.beginPath();

// Left Wheel Bike
bike.fill();
bike.stroke();
bike.beginPath();
bike.arc(150, 600, 45, 0, 360 * Math.PI / 180);

// Right Wheel Bike
bike.fill();
bike.stroke();
bike.beginPath();
bike.arc(380, 600, 45, 0, 360 * Math.PI / 180);

// Wheel Frames Bike
bike.moveTo(380, 600);
bike.lineTo(360, 485);
bike.closePath();

bike.moveTo(360, 485);
bike.lineTo(390, 450);
bike.closePath();

bike.moveTo(360, 485);
bike.lineTo(315, 500);
bike.closePath();

bike.moveTo(368, 530);
bike.lineTo(228, 530);
bike.closePath();

bike.moveTo(228, 530);
bike.lineTo(150, 600);
bike.closePath();

bike.moveTo(150, 600);
bike.lineTo(255, 600);
bike.closePath();

bike.moveTo(255, 600);
bike.lineTo(368, 530);
bike.closePath();

bike.moveTo(255, 600);
bike.lineTo(205, 500);
bike.closePath();

bike.moveTo(180, 500);
bike.lineTo(230, 500);
bike.closePath();

// The Pedals Bike
bike.fill();
bike.stroke();
bike.beginPath();
bike.arc(255, 600, 15, 0, 360 * Math.PI / 180);

bike.moveTo(245, 590);
bike.lineTo(232, 577);
bike.closePath();

bike.moveTo(265, 610);
bike.lineTo(278, 623);
bike.closePath();

bike.stroke();

//-------------------------------------- Canvas Snowman Head --------------------------------------//

//-------------------------------------- Head --------------------------------------//
snowmanHead.fillStyle = '#90cad7';
snowmanHead.strokeStyle = '#205561';

snowmanHead.beginPath();

snowmanHead.save();
snowmanHead.scale(1, 0.8);
snowmanHead.arc(250, 300, 70, 0, 360 * Math.PI / 180);
snowmanHead.restore();

// Nose Snowman Head
snowmanHead.moveTo(240, 225);
snowmanHead.lineTo(228, 257);
snowmanHead.closePath();

snowmanHead.moveTo(228, 257);
snowmanHead.lineTo(246, 257);
snowmanHead.closePath();

// Mouth Snowman Head
snowmanHead.fill();
snowmanHead.stroke();

snowmanHead.beginPath();
snowmanHead.save();
snowmanHead.rotate(8 * Math.PI / 180);
snowmanHead.scale(1, 0.3);
snowmanHead.arc(278, 790, 20, 0, 360 * Math.PI / 180);
snowmanHead.restore();

// Left Eye Snowman Head
snowmanHead.stroke();

snowmanHead.beginPath();
snowmanHead.save();
snowmanHead.scale(1, 0.6);
snowmanHead.arc(218, 360, 8, 0, 360 * Math.PI / 180);
snowmanHead.restore();

snowmanHead.stroke();

snowmanHead.beginPath();
snowmanHead.save();
snowmanHead.scale(0.25, 1);
snowmanHead.arc(865, 215, 3, 0, 360 * Math.PI / 180);
snowmanHead.restore();

// Right Eye Snowman Head
snowmanHead.stroke();

snowmanHead.beginPath();
snowmanHead.save();
snowmanHead.scale(1, 0.6);
snowmanHead.arc(275, 360, 8, 0, 360 * Math.PI / 180);
snowmanHead.restore();

snowmanHead.stroke();

snowmanHead.beginPath();
snowmanHead.save();
snowmanHead.scale(0.25, 1);
snowmanHead.arc(1095, 215, 3, 0, 360 * Math.PI / 180);
snowmanHead.restore();

snowmanHead.fill();
snowmanHead.stroke();

//-------------------------------------- Hat --------------------------------------//
snowmanHead.fillStyle = '#396693';
snowmanHead.strokeStyle = '#262523';

snowmanHead.beginPath();
snowmanHead.save();
snowmanHead.scale(1, 0.2);
snowmanHead.arc(245, 920, 70, 0, 360 * Math.PI / 180);
snowmanHead.restore();

snowmanHead.fillRect(220, 100, 65, 80);
snowmanHead.strokeRect(220, 100, 65, 80);

snowmanHead.fill();
snowmanHead.stroke();

snowmanHead.beginPath();
snowmanHead.save();
snowmanHead.scale(1, 0.3);
snowmanHead.arc(252.5, 336, 33, 0, 360 * Math.PI / 180);
snowmanHead.restore();

snowmanHead.fillRect(222, 105, 61, 80);
snowmanHead.fill();
snowmanHead.stroke();

//house.moveTo(925, 425);
//house.quadraticCurveTo(960, 390, 995, 425);

snowmanHead.moveTo(220, 171);
snowmanHead.quadraticCurveTo(245, 188, 285, 172);

snowmanHead.fill();
snowmanHead.stroke();