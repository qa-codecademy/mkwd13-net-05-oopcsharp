class Person {
    constructor() {
        this.firstName = 'Trajan';
    }

    getInfo = function () {
        console.log("+");
    }

    static getName = function() {
        console.log("-");
    }
}

let obj = new Person();
obj.getInfo();

Person.getName();