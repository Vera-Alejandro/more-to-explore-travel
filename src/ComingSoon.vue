<template>
  <div class="centered coming-soon-container">
    <v-img class="business-logo" src="./assets/logo.png" :aspect-ratio="16 / 9" :width="300" />
    <h1>Site Coming Soon ...</h1>

    <div class="notify-me sketchy">
      <form action="submit">
        <v-card-title class="form-title">Sign Up To Get Notified </v-card-title>
        <div class="form-inputs">
          <v-text-field
            v-model="name"
            :error-messages="nameErrors"
            :counter="25"
            label="Name"
            required
            @input="$v.name.$touch()"
            @blur="$v.name.$touch()"
          ></v-text-field>
          <v-text-field
            v-model="email"
            :error-messages="emailErrors"
            label="E-mail"
            required
            @input="$v.email.$touch()"
            @blur="$v.email.$touch()"
          ></v-text-field>
        </div>
        <v-row justify="center">
          <v-btn class="btn-notify" @click="addToNotificationList"
            >Notify Me!</v-btn
          >
        </v-row>
      </form>
    </div> 

    <v-snackbar v-model="inDevAlert">
      'Notify Me!' is still in development.
      <template v-slot:action="{ attrs }">
        <v-btn color="green" text v-bind="attrs" @click="inDevAlert = false">
          Close
        </v-btn>
      </template>
    </v-snackbar>
  </div>
</template>


<script>
import { validationMixin } from "vuelidate";
import { required, maxLength, email } from "vuelidate/lib/validators";

export default {
  mixins: [validationMixin],
  validations: {
    name: { required, maxLength: maxLength(25) },
    email: { required, email },
  },
  name: "ComingSoon",
  data() {
    return {
      name: "",
      email: "",
      inDevAlert: false,
    };
  },
  computed: {
    nameErrors() {
      const errors = [];

      if (!this.$v.name.$dirty) return errors;
      !this.$v.name.maxLength &&
        errors.push("Name must be at most 10 characters long");
      !this.$v.name.required && errors.push("Name is required.");

      return errors;
    },
    emailErrors() {
      const errors = [];

      if (!this.$v.email.$dirty) return errors;
      !this.$v.email.email && errors.push("Must be valid e-mail");
      !this.$v.email.required && errors.push("E-mail is required");

      return errors;
    },
  },
  methods: {
    addToNotificationList() {
      // const user = {
      //   fullName: this.name,
      //   emailAddress: this.email
      // };

      // this.$.ajax({
      //   type: "POST",
      //   url: "http://localhost:7071/api/StoreUserNotification",
      //   data: user,
      // })

      console.log("add them");
      this.inDevAlert = true;
      return;
    },
  },
};
</script>

<style>
.centered {
  top: 20%;
  left: 25%;
}

.coming-soon-container {
  width: 50%;
  position: relative;
  text-align: center;
}

.notify-me {
  font-family: "Libre Baskerville", serif;
  display: inline-block;
}

.form-inputs {
  margin-bottom: 1rem;
}

.btn-notify {
  margin-top: 1rem;
}

.business-logo {
  display: block;
  margin: auto;
}

.form-title {
  justify-content: center;
}

.sketchy {
  padding: 2rem 4rem;
  display: inline-block;
  border: 3px solid #333333;
  font-size: 2.5rem;
  border-radius: 2% 6% 5% 4% / 1% 1% 2% 4%;
  text-transform: uppercase;
  letter-spacing: 0.3ch;
  background: #ffffff;
  position: relative;
}

h1 {
  font-family: "Satisfy", cursive;
  text-align: center;
  margin-bottom: 2rem;
  font-size: 3rem;
}
</style>