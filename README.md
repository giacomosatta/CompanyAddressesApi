# Company Addresses Web API

## Overview

This project implements a simple ASP.NET Core Web API with a POST endpoint for handling company data. The API receives a payload containing company details and associated addresses, validating and asynchronously storing the addresses in a text file named `company-addresses-<GUID>.txt`.

## Project Structure

1. **CompanyAddressesApi**
- **Models:** Contains the `Company` and `Address` classes.
- **Controllers:** Houses the API endpoint logic.
- **Services:** Provides services for handling file I/O and asynchronous operations.
2. **CompanyAddressesApi.Tests**
- **Resources:** Contains the JSON for POST PayLoad.
- **Tests:** One class test for class.

## Getting Started

1. **Clone the Repository:**
   
   ```bash
   git clone https://github.com/giacomosatta/CompanyAddressesApi.git
   cd CompanyAddressesApi
   cd CompanyAddressesApi  
   
2. **Run the Application:**
   ```bash
   dotnet run
   
3. **Use the API:**
    - Endpoint: POST /api/company
    - Sample Payload:
   ```bash
    {
    "Name": "Initech",
    "RegistrationNumber": "123456789",
    "Addresses": [
        {
            "Street": "1234 Elm Street",
            "City": "Springfield",
            "PostalCode": "12345",
            "Country": "USA"
        },
        {
            "Street": "9876 Oak Street",
            "City": "Shelbyville",
            "PostalCode": "67890",
            "Country": "USA"
        }
      ]
    }

## Asynchronous File I/O

File I/O operations, including saving addresses to `company-addresses-<Guid>.txt`, are performed asynchronously to ensure optimal performance.

## Error Handling

The API includes robust error handling to respond with appropriate HTTP status codes for any potential errors during the process.

## Personal Considerations:
- For each generated file, I added a Guid for respect the IdemPotent criteria (repeated application of the same operation produces the same result as if it had been applied only once)
- Fromat the output file looking for the best readability
