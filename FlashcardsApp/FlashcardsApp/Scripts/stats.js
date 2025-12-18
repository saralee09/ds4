fetch('/api/stats/1')
    .then(res => res.json())
    .then(data => {
        const ul = document.getElementById('stats');
        data.forEach(s => {
            const li = document.createElement('li');
            li.innerText = `Fecha: ${s.Date} - Score: ${s.Score}`;
            ul.appendChild(li);
        });
    });
const userId = 1;

/* ======================
   PROGRESO EN EL TIEMPO
====================== */
fetch(`/api/stats/${userId}`)
    .then(res => res.json())
    .then(data => {
        const labels = data.map(x => x.SessionDate);
        const scores = data.map(x => x.Score);

        const ctx = document.getElementById('progressChart').getContext('2d');
        new Chart(ctx, {
            type: 'line',
            data: {
                labels: labels,
                datasets: [{
                    label: 'Score por sesión',
                    data: scores,
                    fill: false,
                    borderWidth: 2
                }]
            }
        });
    });


fetch(`/api/hardest/${userId}`)
    .then(res => res.json())
    .then(data => {
        const labels = data.map(x => x.Word);
        const fails = data.map(x => x.FailCount);

        const ctx = document.getElementById('hardestChart').getContext('2d');
        new Chart(ctx, {
            type: 'bar',
            data: {
                labels: labels,
                datasets: [{
                    label: 'Cantidad de fallos',
                    data: fails
                }]
            }
        });
    });
