# PdfNox
A web app and Fortnox integration created to parse invoices from PDFs, built with ASP.NET.

## Table of Contents
- [PdfNox](#pdfnox)
  - [Table of Contents](#table-of-contents)
  - [General Info](#general-info)
  - [Features](#features)
  - [Technologies](#technologies)
    - [Design Choices](#design-choices)
  - [Setup](#setup)
  - [Links](#links)

## General Info
This project is a web app created as a Fortnox integration, designed to parse invoices from PDFs. The web app sends the invoice data to Fortnox's integration API.

## Features
- Parses invoice data from PDFs
- Sends invoice data to Fortnox's integration API

## Technologies
- ASP.NET MVC

### Design Choices
I have chosen to use the ASP.NET MVC pattern as I previously have worked alot with the Minimal API pattern and I would now like to become more familiar with Controllers.

Because of the limited scope of the web app I have also decided to not use any frontend libraries like React, Angular or Vue.

The Fortnox API uses the OAuth2 Authorization Code flow, when building single page applications or native apps without the PKCE extension the client secret is available publicly and could therefore be accessed by anyone by inspecting the code[^1]. I have therefore decide not to build a SPA, but instead build a more traditional multi page application. 

## Setup

## Links
[^1]: ["Authorization Code Grant", https://www.oauth.com/oauth2-servers/server-side-apps/authorization-code/](https://www.oauth.com/oauth2-servers/server-side-apps/authorization-code/)