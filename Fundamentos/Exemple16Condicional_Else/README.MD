Claro! Aqui vai um **exercício um pouco complexo com condicionais**, adequado para quem já entende `if`, `elif`, `else` e quer praticar lógica mais elaborada:

---

## 🧠 **Exercício: Sistema de Classificação de Viagem**

Você deve criar um programa que avalia o perfil de uma pessoa para decidir se ela **pode viajar**, **precisa de análise adicional** ou **não pode viajar**.

O programa deve pedir:

1. **Idade**
2. **Possui passaporte?** (sim/não)
3. **Possui visto válido?** (sim/não)
4. **Pontuação de risco** (0 a 100) — onde 0 é risco zero e 100 é risco máximo
5. **Origem da viagem** (nacional / internacional)

---

## ✔️ **Regras**

### 🔹 1. Proibição automática:

A pessoa **não pode viajar** se:

* tiver menos de 18 anos **e** estiver viajando internacionalmente
* **não** tiver passaporte para viagem internacional
* possuir pontuação de risco **≥ 70**

### 🔹 2. Análise adicional:

A pessoa **precisa de análise manual** se:

* estiver viajando internacionalmente, tiver passaporte **mas não tiver visto**
* pontuação de risco entre **40 e 69**

### 🔹 3. Autorizado:

A pessoa **pode viajar** se:

* idade ≥ 18
* pontuação de risco < 40
* possuir todos os documentos necessários (para viagem internacional: passaporte + visto)

---

## 🏁 **Saída final**

Seu programa deve imprimir uma das mensagens:

* `"VIAGEM APROVADA"`
* `"VIAGEM EM ANÁLISE"`
* `"VIAGEM NEGADA"`

---

## 🔧 **Desafio extra (opcional)**

Use operadores lógicos combinados (`and`, `or`, `not`) para deixar as condições claras e eficientes.

---

Se quiser, posso criar **a solução**, **testes**, ou até transformar esse enunciado em uma **versão mais difícil**. Quer a resolução?
