# Supreme GUI 
Buys clothes at Supreme (supremenewyork.com) automatically.

![Image of GUI](https://cloud.githubusercontent.com/assets/342334/24610747/137d71ea-1880-11e7-894a-56d3505755d0.png)

## Run
- Enter your details in Settings.
- Hit Order exactly at drop time.

## Notes
- Gets around Google NoCaptcha ReCaptcha (for now).
(as of now g-recaptcha-response is not validated serverside when JS is turned off)
- Press Order only when new items are already live (11:00:01 LDN Time).
- Product site must contain all given keywords for the product to be found.
- You must not use special characters (e.g. ä, ö, ü).
- `Categories.All` will be the slowest, `Categories.New` the fastest.
