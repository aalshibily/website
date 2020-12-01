window.onload = function () {
    console.log("Initializing Particle JS");
    Particles.init({
        selector: '.background',
        color: "#00FFFF",
        maxParticles: 100,
        connectParticles: true
    });
};