const person = async () => {
    const response = await fetch('https://localhost:7241/Data/person');
    const data = await response.json();

    const ele = document.getElementById('person');
    const html = data.map(x => `
        <div>
            <b>Name - </b><p>${x.name}</p>
            <b>Address - </b><p>${x.address}</p>
        </div>`).join('');

    ele.innerHTML = html;
    return data;
}

const job = async () => {
    const response = await fetch('https://localhost:7241/Data/job');
    const data = await response.json();

    const ele = document.getElementById('job');
    const html = data.map(x => `
        <div>
            <b>id - </b><p>${x.id}</p>
            <b>name - </b><p>${x.name}</p>
            <b>description - </b><p>${x.description}</p>
        </div>`).join('');

    ele.innerHTML = html;
    return data;
}

const person_job = async () => {
    const response = await fetch('https://localhost:7241/Data/peoplesjobs');
    const data = await response.json();

    const ele = document.getElementById('person_job');
    const html = data.map(x => `
        <div>
            <b>id ${x.id}</b>
            <p>person details</p>
            <p>${x.person.name}</p>
            <p>${x.job.name}</p>
        </div>`).join('');

    ele.innerHTML = html;
    return data;
}