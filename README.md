# 🛒 Shopping Cart App – Windows Forms (C#)

## 📌 Descripción del Proyecto

**Shopping Cart App** es una aplicación de escritorio desarrollada en **C# utilizando Windows Forms**, cuyo propósito es servir como **prueba de concepto** para demostrar el uso de formularios, controles gráficos y manejo de eventos en un entorno Windows.

La aplicación simula un **carrito de compras básico**, permitiendo al usuario seleccionar productos, agregarlos a una lista y calcular el total de manera dinámica.

---

## 🎯 Objetivo

* Comprobar el funcionamiento de **Windows Forms**
* Practicar el uso de controles gráficos
* Implementar eventos de botones
* Manejar datos de forma dinámica en una aplicación de escritorio

---

## 🧪 Alcance del Proyecto

Este proyecto es una **prueba académica de Windows Forms**, no una aplicación comercial.
Se enfoca en la correcta interacción entre interfaz gráfica y lógica del programa.

---

## 🖥️ Interfaz de Usuario

La aplicación cuenta con los siguientes controles:

* **ComboBox** para seleccionar productos
* **Button** para agregar productos al carrito
* **ListBox** para mostrar los productos seleccionados
* **Label** para mostrar el total a pagar
* **Button** para limpiar el carrito
* **Button** para cerrar la aplicación con confirmación

---

## ⚙️ Funcionamiento

1. El usuario selecciona un producto del ComboBox.
2. Presiona el botón **Agregar**.
3. El producto se añade al carrito.
4. El total se actualiza automáticamente.
5. El botón **Limpiar** reinicia el carrito.
6. El botón **Cerrar** solicita confirmación antes de salir.

---

## 🧠 Conceptos Aplicados

* Windows Forms
* Manejo de eventos (`Click`)
* Uso de controles gráficos
* Colecciones (`Dictionary`)
* Variables y métodos
* Programación estructurada
* Interacción usuario–sistema

---

## 🧩 Estructura del Código

* `Form1.cs`: Contiene la lógica principal de la aplicación.
* `LoadProducts()`: Carga los productos al sistema.
* Eventos:

  * `btnAdd_Click`
  * `btnClear_Click`
  * `btnClose_Click`

---

## 🛠️ Tecnologías Utilizadas

* Lenguaje: **C#**
* Framework: **.NET**
* Tipo de aplicación: **Windows Forms**
* Entorno de desarrollo: **Visual Studio**
