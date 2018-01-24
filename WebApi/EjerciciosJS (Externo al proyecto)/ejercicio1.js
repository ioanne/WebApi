class Employee {
    constructor(first_name, last_name) {
        this.first_name = first_name;
        this.last_name = last_name;
        this.salary = 15000;
    }

    increaseSalary(salary) {
        this.salary = this.salary + salary
    }

    personalData() {
        console.log(this.first_name, this.last_name, this.salary)
    }

}