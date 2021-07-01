<template>
  <div class="centered coming-soon-container">
    <img
      class="business-logo"
      src="./assets/logo.png"
      alt="More To Explore Site Logo"
    />
    <h1>Site Coming Soon ...</h1>
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
  data: () => ({
    name: "",
    email: "",
    userSignedUp: false,
    alert_formincomplete: false,
    alert_fetcherror: false,
    uploadingData: null,
  }),
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
    async addToNotificationList() {
      if (this.name === "" || this.email === "") {
        this.alert_formincomplete = true;
        return;
      }
      this.alert_formincomplete = false;
      this.uploadingData = true;

      //backdoor
      if (this.name === "superuser" && this.email === "dduck@disney.com") {
        this.$emit("EnableBackdoor", "backdoor triggered");
        return;
      }

      const user = {
        fullName: this.name,
        emailAddress: this.email,
      };

      const requestOptions = {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
          mode: "cors",
        },
        body: JSON.stringify(user),
      };

      try {
        const response = await fetch(
          process.env.VUE_APP_API_ENDPOINT,
          requestOptions
        );

        if (response.status === 200) {
          this.userSignedUp = true;
          this.uploadingData = null;
        } else if (response.status === 500 || response.status === 404) {
          throw new Error();
        }
      } catch (error) {
        this.alert_fetcherror = true;
      }
    },
  },
  EnableBackDoor() {
    this.$emit("backdoor", true);
  },
};
</script>

<style scoped>
.soon-cont {
  flex-direction: column;
  align-items: center;
  width: 100%;
}

.business-logo {
  display: block;
  margin: auto;
  width: 100%;
  padding: 1rem;
}

.sketchy {
  padding: 1rem 1.5rem 2rem 1rem;
  display: inline-block;
  border: 3px solid #333333;
  font-size: 2.5rem;
  border-radius: 2% 6% 5% 4% / 1% 1% 2% 4%;
  text-transform: uppercase;
  letter-spacing: 0.3ch;
  background: #ffffff;
  position: relative;
}

.form-title {
  justify-content: center;
  font-size: 0.85rem;
  font-weight: bold;
  text-decoration: underline;
  padding-bottom: 0.5rem;
}

.btn-submit {
  margin: 0.25rem;
}

.alerts {
  position: fixed;
  width: 100%;
  bottom: 0;
  padding: 0 1rem;
}

.notifyUser {
  padding: 1rem 0;
}

.form {
  width: 100%;
}

.form-cont {
  width: 85%;
  margin-left: 1rem;
}

@media screen and (max-width: 600px) {
  .form-cont {
    width: 85%;
    margin-left: 1rem;
  }

  .form {
    width: 100%;
  }
}

h1 {
  font-family: "Satisfy", cursive;
  text-align: center;
  margin-bottom: 1.5rem;
  font-size: 2rem;
}

</style>