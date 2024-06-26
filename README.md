## Example
Currently just outputs to console, works well enough. Just a quick hack to get better visibility into our submodule usage so I can plan GitHub migration.

- \lib\foocrypt (lib\foocrypt  ..\..\foo\foocrypt.git)
  - \lib\foocrypt\lib\build (lib\build  git@gitlab.foo.local:saas\build.git)
  - \lib\foocrypt\lib\libsodium (lib\libsodium  git@gitlab.foo.local:opensource\libsodium.git)
    - \lib\foocrypt\lib\libsodium\lib\build (lib\build  git@gitlab.foo.local:saas\build.git)
  - \lib\foocrypt\lib\zxcvbn_c (lib\zxcvbn_c  git@gitlab.foo.local:opensource\zxcvbn-c.git)
    - \lib\foocrypt\lib\zxcvbn_c\lib\build (lib\build  git@gitlab.foo.local:saas\build.git)
- \lib\zBuild (lib\zBuild  ..\..\foo\zBuild.git)
- \lib\yUI (lib\yUI  ..\..\foo\yUI.git)
- \lib\rustsoap (lib\rustsoap  ..\..\foo\rustsoap.git)
- \lib\dunit (lib\dunit  ..\..\opensource\dunit)
- \lib\fptest (lib\fptest  ..\..\opensource\fptest.git)
- \lib\dataDat (lib\dataDat  ..\..\foo\dataDat.git)
  - \lib\dataDat\lib\rapidjson (lib\rapidjson  https:\\github.com\miloyip\rapidjson.git)
    - \lib\dataDat\lib\rapidjson\thirdparty\gtest (thirdparty\gtest  https:\\github.com\google\googletest.git)
- \lib\thingtwo (lib\thingtwo  ..\..\op\thingtwo.git)
  - \lib\thingtwo\lib\thirdparty\fptest (lib\thirdparty\fptest  ..\..\opensource\fptest.git)
  - \lib\thingtwo\lib\thirdparty\googletest (lib\thirdparty\googletest  ..\..\opensource\googletest.git)
  - \lib\thingtwo\lib\thirdparty\rapidjson (lib\thirdparty\rapidjson  ..\..\opensource\rapidjson.git)
    - \lib\thingtwo\lib\thirdparty\rapidjson\thirdparty\gtest (thirdparty\gtest  https:\\github.com\google\googletest.git)
- \lib\dataTables (lib\dataTables  ..\..\foo\dataTables.git)
- \lib\somedata (lib\somedata  ..\..\reporting\somedata.git)
  - \lib\somedata\lib\fptest (lib\fptest  git@gitlab.foo.local:opensource\fptest.git)
- \lib\tdbf (lib\tdbf  ..\..\opensource\tdbf.git)
  - \lib\tdbf\lib\build (lib\build  git@gitlab.foo.local:saas\build.git)
  - \lib\tdbf\lib\dunit (lib\dunit  git@gitlab.foo.local:opensource\dunit.git)
- \lib\WebService (lib\WebService  ..\..\op\service-libraries\WebService.git)
  - \lib\WebService\lib\cpprestsdk (lib\cpprestsdk  ..\..\..\opensource\cpprestsdk.git)
    - \lib\WebService\lib\cpprestsdk\Release\libs\websocketpp (websocketspp  https:\\github.com\zaphoyd\websocketpp\)
    - \lib\WebService\lib\cpprestsdk\vcpkg (vcpkg  https:\\github.com\Microsoft\vcpkg)
  - \lib\WebService\lib\thingtwo (lib\thingtwo  ..\..\thingtwo.git)
    - \lib\WebService\lib\thingtwo\lib\thirdparty\fptest (lib\thirdparty\fptest  ..\..\opensource\fptest.git)
    - \lib\WebService\lib\thingtwo\lib\thirdparty\googletest (lib\thirdparty\googletest  ..\..\opensource\googletest.git)
    - \lib\WebService\lib\thingtwo\lib\thirdparty\rapidjson (lib\thirdparty\rapidjson  ..\..\opensource\rapidjson.git)
      - \lib\WebService\lib\thingtwo\lib\thirdparty\rapidjson\thirdparty\gtest (thirdparty\gtest  https:\\github.com\google\googletest.git)
- \lib\zlib (lib\zlib  ..\..\opensource\zlib.git)
  - \lib\zlib\lib\build (lib\build  git@gitlab.foo.local:saas\build.git)
