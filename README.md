# Google OAuth Authentication Setup

## Step 1: Configure `appsettings.json`
Replace the `ClientId` and `ClientSecret` in your `appsettings.json` file with the credentials from your Google OAuth project.

```json
"Authentication": {
  "Google": {
    "ClientId": "YOUR_CLIENT_ID",
    "ClientSecret": "YOUR_CLIENT_SECRET"
  }
}
```

## Step 2: Set Up Authorized Redirect URIs
Ensure that the Authorized Redirect URIs in your Google Cloud OAuth settings match your application's URL.

### Example:
If your app runs on `https://localhost:7185`, update the redirect URI to:
```
https://localhost:7185/signin-google
```

### How to Update Redirect URIs:
1. Go to [Google Cloud Console](https://console.cloud.google.com/)
2. Navigate to **APIs & Services** > **Credentials**
3. Select your **OAuth 2.0 Client ID**
4. Under **Authorized redirect URIs**, add or update the correct URL

## Step 3: Run Your Application
Start your application and test Google authentication using the configured settings.

---
## Sameple Project
![Image](https://github.com/user-attachments/assets/48d39e34-5dec-44be-9220-0bc558b0ad81)
