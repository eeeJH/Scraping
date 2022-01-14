# Using Selenium. C #

Wpf 를 이용하여 Web Scraping.

## Web Scraping 이 무엇인가? ##

Web Scraping 은 주로 web site 에서 정보를 추출하는 데 사용되는 일반적인 기술입니다. 관련 데이터를 scrap해야 하는 page 의 HTML 적절한 도구를 사용하여 처리하고, dataBase, excel 등에 저장하여 데이터를 추가 분석에 사용할 수 있습니다.


더 큰 데이터 크기(또는 양)의 경우 scraping 은 web site 를 hosting 하는 server에 상당한 양의 load 를 추가할 수 있습니다. scrap 활동이 web site 에서의 service 를 방해하지 않는 한, 해당 web site 를 scrap 하는 것은 전혀 문제가 되지 않습니다.

---

## 정적 및 동적 Web Scraping의 차이점 ##

### 정적 ###

정적 web page 에서 page 의 모든 Data 는 site 를 처음 호출 할 때, 사용할 수 있습니다. 그래서 처음 site 를 호출 한 뒤, server 와 연결을 유지할 필요가 없습니다. HTML 문서를 download 할 수 있고, scrap 할 수 있는 도구를 사용하여 data 를 scrap 할 수 있습니다.

### 동적 ###

반면에 동적 web page 에서 대부분의 기능은 javascript 코드에 대한 응답이 발생합니다. 따라서 Selenium C# 라이브러리는 동적 javascript 코드를 rendering 하는데 도움이 되니다.

#### Selenium c# 으로 동적 Web Page Scraping  ####

Nuget Pakages 추가

1. Selenium.WebDriver
2. NUnit
3. NUnit3TestAdapter
4. Microsoft.NET.Test.Sdk