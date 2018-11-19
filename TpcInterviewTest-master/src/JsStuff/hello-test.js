/*
The test is already set up. Just look in hello.js and make the test pass. 
*/
require('chai').should();
var hellosvc=require ('../JsStuff/hello')

var assert = require('assert');
describe('Hello', function () {
  it('should return hello', function () {
    // write a test to check if hello.js returns the string 'hello'
	assert.equal('hello', hellosvc.hello());

  });
});
