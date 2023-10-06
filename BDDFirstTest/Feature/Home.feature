Feature: Home

@Home_Page
Scenario Outline: Check_Website_Open
Given Open the url '<URL>' on chrome browser
Then Check application name as '<ApplicationName>'
Examples: 
| URL                     | ApplicationName      |
| http://localhost:54978/ | My First Application |


Scenario Outline: Check_Home_Page_Content
Given Open the url '<URL>' on chrome browser
Then Check application name as '<ApplicationName>'
And Two menu '<Menu>' should be visible on UI
And '<Content>' should be in the top middle portion
And bottom having '<BottomValue>' as value
When User click on '<ClickMenu>' Menu
Then User redirect to '<ClickMenu>' page
Examples: 
| URL                     | ApplicationName      | Menu          | Content | BottomValue               | ClickMenu |
| http://localhost:54978/ | My First Application | Home, Privacy | Welcome | © 2021 - WebApplication - | Privacy   |