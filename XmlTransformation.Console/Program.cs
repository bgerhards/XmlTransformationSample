using System.Xml.Serialization;
using XmlTransformation.Console;

var serializer = new XmlSerializer(typeof(SampleOutputClass));


// Multiple item simple structure
const string xml1 = @"<?xml version=""1.0""?>
                    <Root>
                        <ListOfStrings>Jani</ListOfStrings>
                        <ListOfStrings>baNi</ListOfStrings>
                        <ListOfStrings>FoFani</ListOfStrings>
                    </Root>";
using var textReader1 = new StringReader(xml1);
var output1 = (SampleOutputClass) serializer.Deserialize(textReader1);


// Single item simple structure
const string xml2 = @"<?xml version=""1.0""?>
                    <Root>
                        <ListOfStrings>Another Name</ListOfStrings>
                    </Root>";
using var textReader2 = new StringReader(xml2);
var output2 = (SampleOutputClass) serializer.Deserialize(textReader2);


// Multiple item nested structure
var serializer2 = new XmlSerializer(typeof(SampleOutputClass2));
const string xml3 = @"<?xml version=""1.0""?>
                    <Root>
                        <NestedClass>
                            <SampleNestedRepeatedClass>
                                <Name>Bob</Name>
                                <Age>12</Age>
                                <Word>Acorn</Word>
                            </SampleNestedRepeatedClass>
                        </NestedClass>
                    </Root>";
using var textReader3 = new StringReader(xml3);
var output3 = (SampleOutputClass2) serializer2.Deserialize(textReader3);


// Single item simple structure
const string xml4 = @"<?xml version=""1.0""?>
                    <Root>
                        <NestedClass>
                            <SampleNestedRepeatedClass>
                                <Name>Bob</Name>
                                <Age>12</Age>
                                <Word>Acorn</Word>
                            </SampleNestedRepeatedClass>
                            <SampleNestedRepeatedClass>
                                <Name>Barb</Name>
                                <Age>10</Age>
                                <Word>Donut</Word>
                            </SampleNestedRepeatedClass>
                            <SampleNestedRepeatedClass>
                                <Name>Tim</Name>
                                <Age>28</Age>
                                <Word>Fro</Word>
                            </SampleNestedRepeatedClass>
                        </NestedClass>
                    </Root>";
using var textReader4 = new StringReader(xml4);
var output4 = (SampleOutputClass2) serializer2.Deserialize(textReader4);
