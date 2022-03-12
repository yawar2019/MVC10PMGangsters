const person = { fname: "John", lname: "Doe", age: 25 }; var txt = ""; for (let t in person) txt += person[t] + " "; alert(txt), $("#demo").val(txt);
 