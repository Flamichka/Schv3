
function checkGroupOrFio(val) {
    console.log(val);
    if (val == "") {
        document.getElementById("week").disabled = true;
        document.getElementById("week").value = "";
        document.getElementById("this_week").disabled = true;
        document.getElementById("next_week").disabled = true;
        document.getElementById("show_schedule").disabled = true;
    }
    else {
        document.getElementById("week").removeAttribute("disabled");
        document.getElementById("this_week").removeAttribute("disabled");
        document.getElementById("next_week").removeAttribute("disabled");
    }
}

function checkWeek(val) {
    console.log(val);
    if (val == "") {
        document.getElementById("search").disabled = true;;
    }
    else {
        document.getElementById("show_schedule").removeAttribute("disabled");
    }
}

function getWeek(val) {
    let thisYear = new Date().getFullYear();
    let start = new Date('09/01/' + thisYear);
    let today = new Date();
    const week = (start, today) => {
        let difference = today.getTime() - start.getTime();
        let total_week = Math.ceil(difference / (1000 * 3600 * 24*7));
        return total_week+val;
    }
    document.getElementById("week").value = week(start, today) + " неделя";
    document.getElementById("show_schedule").removeAttribute("disabled");
    console.log(week(start, today));
}