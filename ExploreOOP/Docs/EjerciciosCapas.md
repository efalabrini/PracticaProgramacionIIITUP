# Ejercicio 1

Agregar a la capa de interfaz, la funcionalidad de mostrar el ID (Propiedad Number) de la cuenta en el listado, para que se vea de la siguiente manera:

Account ID: 1234567890 Account Cuenta 1 Balance 10

Account ID: 1234567891 Account Cuenta 2 Balance 10

Account ID: 1234567892 Account Cuenta 3 Balance 10

Crear una rama llamada: feature/exploreoop-1-agregar-id-a-listado-de-cuentas
Crear PR a origen:master

# Ejercicio 2
En la capa de negocio
Agregar a la clase LineOfCreditAccountService.cs los métodos
- public LineOfCreditAccount Get(int id)
- public void Delete(int id)

e implementar la interfaz ILineOfCreditAccountService.cs

Crear una rama llamada: feature/exploreoop-2-agregar-metodos-e-interface-en-lineofcreditaccountservice

Crear PR a origen:master 


# Ejercicio 3
En la capa de persistencia
Implementar en la clase LineOfCreditAccountRepositoryMoked.cs, los métodos
- public void Delete(int id)
- public LineOfCreditAccount Get(int id)

Crear una rama llamada: feature/exploreoop-3-agregar-metodos-en-lineofcreditaccountrepositorymoked

Crear PR a origen:master 

# Ejercicio 4
En la capa de interfaz, agregar las opciones
3 - Find a line of credit account by ID
4 - Delete a line of credit account

Crear una rama llamada: feature/exploreoop-4-agregar-opciones-find-y-delete-en-interfaz

Crear PR a origen:master 
