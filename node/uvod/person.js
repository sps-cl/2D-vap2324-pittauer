class Person{
    constroctor(name, surname, id) {
        this.name = name;
        this.surname = surname;
        this.id = id;
    }
}


class Car{
    constructor(brand, model){
        this.brand = brand;
        this.model = model;
    }
}

module.exports = {Person, Car}
