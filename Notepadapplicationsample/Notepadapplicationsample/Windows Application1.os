<OpenSpanDesignDocument Version="19.1.0.1" Serializer="2.0" Culture="en-US">
  <ComponentInfo>
    <Type Value="OpenSpan.Adapters.Windows.WindowsAdapter" />
    <Assembly Value="OpenSpan.Adapters.Windows" />
    <AssemblyReferences>
      <Assembly Value="mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="OpenSpan, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters.ActiveX, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters.Windows, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters.WinInet, Version=19.1.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
    </AssemblyReferences>
    <DynamicAssemblyReferences />
    <FileReferences>
      <File Value="OpenSpan.WinInet.x32.dll" />
      <File Value="OpenSpan.WinInet.x64.dll" />
    </FileReferences>
    <BuildReferences>
      <File Value="DefaultWindowFactoryConfiguration.xml" />
      <File Value="openspan.ini" />
      <File Value="OpenSpan.WinInet.x32.dll" />
      <File Value="OpenSpan.WinInet.x64.dll" />
      <File Value="OpenSpan.x32.sys" />
      <File Value="OpenSpan.x64.sys" />
      <File Value="Pega.ActiveX.x32.dll" />
      <File Value="Pega.ActiveX.x64.dll" />
      <File Value="Pega.GlobalAllocator.x32.dll" />
      <File Value="Pega.GlobalAllocator.x64.dll" />
      <File Value="Pega.Scout.x32.dll" />
      <File Value="Pega.Scout.x64.dll" />
      <File Value="Pega.Security.x32.dll" />
      <File Value="Pega.Security.x64.dll" />
      <File Value="Pega.SharedMemory.x32.dll" />
      <File Value="Pega.SharedMemory.x64.dll" />
      <File Value="Pega.Sinon.x32.dll" />
      <File Value="Pega.Sinon.x64.dll" />
      <File Value="Pega.Utilities.x32.dll" />
      <File Value="Pega.Utilities.x64.dll" />
      <File Value="Pega.WER.x32.dll" />
      <File Value="Pega.WER.x64.dll" />
      <File Value="Pega.Windows.Broker.x32.dll" />
      <File Value="Pega.Windows.Broker.x64.dll" />
      <File Value="Pega.WinQueue.x32.dll" />
      <File Value="Pega.WinQueue.x64.dll" />
    </BuildReferences>
  </ComponentInfo>
  <Component Version="1.0">
    <OpenSpan.Adapters.Windows.WindowsAdapter Name="Windows Application1" Id="WindowsAdapter-8D72AF5B97F68FB">
      <Path Value="C:\WINDOWS\system32\notepad.exe | System" />
      <WorkingDirectory Value="C:\WINDOWS\system32" />
      <Content Name="Controls">
        <Items>
          <OpenSpan.Adapters.Controls.Form Name="Untitled_Subtraction_Notepad" Id="Form-8D72AF5C916CD07">
            <DummyPropertyToDetectReplaceUndo Value="0" />
            <ForwardObjectExplorerEvent Value="True" />
            <MatchingIndex Value="0" />
            <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.Form, OpenSpan.Adapters.Windows" />
            <Content Name="Controls">
              <Items>
                <OpenSpan.Adapters.Controls.TextBox Name="txtTextBox" Id="TextBox-8D72AF5C909A768">
                  <DummyPropertyToDetectReplaceUndo Value="0" />
                  <ForwardObjectExplorerEvent Value="True" />
                  <MatchingIndex Value="0" />
                  <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.TextBox, OpenSpan.Adapters.Windows" />
                  <Content Name="MatchRules">
                    <Items>
                      <OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Name="classNameMatchRule2" Id="ClassNameMatchRule-8D72AF5C92619DF">
                        <ClassName Value="Edit" />
                      </OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule>
                      <OpenSpan.Adapters.Windows.MatchRules.ControlIdMatchRule Name="controlIdMatchRule1" Id="ControlIdMatchRule-8D72AF5C92BDDBA">
                        <ControlId Value="15" />
                      </OpenSpan.Adapters.Windows.MatchRules.ControlIdMatchRule>
                    </Items>
                  </Content>
                </OpenSpan.Adapters.Controls.TextBox>
                <OpenSpan.Adapters.Controls.MenuItem Name="New_CtrlPlusN" Id="MenuItem-8D72AF5D596F2E3">
                  <DummyPropertyToDetectReplaceUndo Value="0" />
                  <ForwardObjectExplorerEvent Value="True" />
                  <FullPath Value="" />
                  <MatchingIndex Value="1" />
                  <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.MenuItem, OpenSpan.Adapters.Windows" />
                  <Content Name="MatchRules">
                    <Items>
                      <OpenSpan.Adapters.Windows.MatchRules.MenuItemPathMatchRule Name="menuItemPathMatchRule1" Id="MenuItemPathMatchRule-8D72AF5D59D5213">
                        <Path Value="File/New Ctrl+N" />
                      </OpenSpan.Adapters.Windows.MatchRules.MenuItemPathMatchRule>
                    </Items>
                  </Content>
                </OpenSpan.Adapters.Controls.MenuItem>
                <OpenSpan.Adapters.Controls.MenuItem Name="New_Window_CtrlPlusShiftPlusN" Id="MenuItem-8D72AF5D64759EE">
                  <DummyPropertyToDetectReplaceUndo Value="0" />
                  <ForwardObjectExplorerEvent Value="True" />
                  <FullPath Value="" />
                  <MatchingIndex Value="2" />
                  <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.MenuItem, OpenSpan.Adapters.Windows" />
                  <Content Name="MatchRules">
                    <Items>
                      <OpenSpan.Adapters.Windows.MatchRules.MenuItemPathMatchRule Name="menuItemPathMatchRule2" Id="MenuItemPathMatchRule-8D72AF5D64C140A">
                        <Path Value="File/New Window Ctrl+Shift+N" />
                      </OpenSpan.Adapters.Windows.MatchRules.MenuItemPathMatchRule>
                    </Items>
                  </Content>
                </OpenSpan.Adapters.Controls.MenuItem>
                <OpenSpan.Adapters.Controls.MenuItem Name="Open_CtrlPlusO" Id="MenuItem-8D72AF5D6F1FCA6">
                  <DummyPropertyToDetectReplaceUndo Value="0" />
                  <ForwardObjectExplorerEvent Value="True" />
                  <FullPath Value="" />
                  <MatchingIndex Value="3" />
                  <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.MenuItem, OpenSpan.Adapters.Windows" />
                  <Content Name="MatchRules">
                    <Items>
                      <OpenSpan.Adapters.Windows.MatchRules.MenuItemPathMatchRule Name="menuItemPathMatchRule3" Id="MenuItemPathMatchRule-8D72AF5D6F45D2A">
                        <Path Value="File/Open... Ctrl+O" />
                      </OpenSpan.Adapters.Windows.MatchRules.MenuItemPathMatchRule>
                    </Items>
                  </Content>
                </OpenSpan.Adapters.Controls.MenuItem>
                <OpenSpan.Adapters.Controls.MenuItem Name="Save_CtrlPlusS" Id="MenuItem-8D72AF5D780719F">
                  <DummyPropertyToDetectReplaceUndo Value="0" />
                  <ForwardObjectExplorerEvent Value="True" />
                  <FullPath Value="" />
                  <MatchingIndex Value="4" />
                  <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.MenuItem, OpenSpan.Adapters.Windows" />
                  <Content Name="MatchRules">
                    <Items>
                      <OpenSpan.Adapters.Windows.MatchRules.MenuItemPathMatchRule Name="menuItemPathMatchRule4" Id="MenuItemPathMatchRule-8D72AF5D783C525">
                        <Path Value="File/Save Ctrl+S" />
                      </OpenSpan.Adapters.Windows.MatchRules.MenuItemPathMatchRule>
                    </Items>
                  </Content>
                </OpenSpan.Adapters.Controls.MenuItem>
                <OpenSpan.Adapters.Controls.MenuItem Name="Save_As_CtrlPlusShiftPlusS" Id="MenuItem-8D72AF5D87E0280">
                  <DummyPropertyToDetectReplaceUndo Value="0" />
                  <ForwardObjectExplorerEvent Value="True" />
                  <FullPath Value="" />
                  <MatchingIndex Value="5" />
                  <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.MenuItem, OpenSpan.Adapters.Windows" />
                  <Content Name="MatchRules">
                    <Items>
                      <OpenSpan.Adapters.Windows.MatchRules.MenuItemPathMatchRule Name="menuItemPathMatchRule5" Id="MenuItemPathMatchRule-8D72AF5D882BDFA">
                        <Path Value="File/Save As... Ctrl+Shift+S" />
                      </OpenSpan.Adapters.Windows.MatchRules.MenuItemPathMatchRule>
                    </Items>
                  </Content>
                </OpenSpan.Adapters.Controls.MenuItem>
                <OpenSpan.Adapters.Controls.MenuItem Name="Exit" Id="MenuItem-8D72AF5D9654E6C">
                  <DummyPropertyToDetectReplaceUndo Value="0" />
                  <ForwardObjectExplorerEvent Value="True" />
                  <FullPath Value="" />
                  <MatchingIndex Value="8" />
                  <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.MenuItem, OpenSpan.Adapters.Windows" />
                  <Content Name="MatchRules">
                    <Items>
                      <OpenSpan.Adapters.Windows.MatchRules.MenuItemPathMatchRule Name="menuItemPathMatchRule6" Id="MenuItemPathMatchRule-8D72AF5D96A39B5">
                        <Path Value="File/Exit" />
                      </OpenSpan.Adapters.Windows.MatchRules.MenuItemPathMatchRule>
                    </Items>
                  </Content>
                </OpenSpan.Adapters.Controls.MenuItem>
              </Items>
            </Content>
            <Content Name="MatchRules">
              <Items>
                <OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule Name="windowTextMatchRule1" Id="WindowTextMatchRule-8D72AF5C91C8F94">
                  <Text Value="Simple|True|(User Culture)|Untitled - Notepad" />
                </OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule>
                <OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Name="classNameMatchRule1" Id="ClassNameMatchRule-8D72AF5C921543A">
                  <ClassName Value="Notepad" />
                </OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule>
              </Items>
            </Content>
          </OpenSpan.Adapters.Controls.Form>
          <OpenSpan.Adapters.ActiveX.ActiveXFactory Name="ActiveXFactory" Id="ActiveXFactory-8D72AF5E2523085">
            <DummyPropertyToDetectReplaceUndo Value="0" />
            <ForwardObjectExplorerEvent Value="True" />
            <MatchingIndex Value="0" />
            <TargetTypeString Value="OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows" />
            <UseKeys Value="True" />
            <Content Name="MatchRules">
              <Items>
                <OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule Name="moduleNameMatchRule1" Id="ModuleNameMatchRule-8D72AF5E25A5875">
                  <Text Value="Simple|True|(User Culture)|ole32.dll" />
                </OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule>
              </Items>
            </Content>
          </OpenSpan.Adapters.ActiveX.ActiveXFactory>
          <OpenSpan.Adapters.WinInet.WinInetFactory Name="WinInetFactory" Id="WinInetFactory-8D72AF5E89794EF">
            <DummyPropertyToDetectReplaceUndo Value="0" />
            <ForwardObjectExplorerEvent Value="True" />
            <MatchingIndex Value="0" />
            <TargetTypeString Value="OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows" />
            <UseKeys Value="True" />
            <Content Name="MatchRules">
              <Items>
                <OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule Name="moduleNameMatchRule2" Id="ModuleNameMatchRule-8D72AF5E89FF571">
                  <Text Value="Simple|True|(User Culture)|wininet.dll" />
                </OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule>
              </Items>
            </Content>
          </OpenSpan.Adapters.WinInet.WinInetFactory>
          <OpenSpan.Adapters.Controls.Form Name="Save_As" Id="Form-8D72AF5F048B9DB">
            <DummyPropertyToDetectReplaceUndo Value="0" />
            <ForwardObjectExplorerEvent Value="True" />
            <MatchingIndex Value="3" />
            <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.Form, OpenSpan.Adapters.Windows" />
            <Content Name="Controls">
              <Items>
                <OpenSpan.Adapters.Controls.Control Name="Control2" Id="Control-8D72AF5F0465914">
                  <DummyPropertyToDetectReplaceUndo Value="0" />
                  <ForwardObjectExplorerEvent Value="True" />
                  <MatchingIndex Value="13" />
                  <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows" />
                  <Content Name="Controls">
                    <Items>
                      <OpenSpan.Adapters.Controls.Control Name="Control1" Id="Control-8D72AF5F043F60E">
                        <DummyPropertyToDetectReplaceUndo Value="0" />
                        <ForwardObjectExplorerEvent Value="True" />
                        <MatchingIndex Value="0" />
                        <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows" />
                        <Content Name="Controls">
                          <Items>
                            <OpenSpan.Adapters.Controls.Control Name="Control" Id="Control-8D72AF5F041933C">
                              <DummyPropertyToDetectReplaceUndo Value="0" />
                              <ForwardObjectExplorerEvent Value="True" />
                              <MatchingIndex Value="2" />
                              <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows" />
                              <Content Name="Controls">
                                <Items>
                                  <OpenSpan.Adapters.Controls.ComboBox Name="cmbComboBox" Id="ComboBox-8D72AF5F03F310E">
                                    <DummyPropertyToDetectReplaceUndo Value="0" />
                                    <ForwardObjectExplorerEvent Value="True" />
                                    <MatchingIndex Value="0" />
                                    <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.ComboBox, OpenSpan.Adapters.Windows" />
                                    <Content Name="Controls">
                                      <Items>
                                        <OpenSpan.Adapters.Controls.TextBox Name="txtTextBox1" Id="TextBox-8D72AF5F03A6C58">
                                          <DummyPropertyToDetectReplaceUndo Value="0" />
                                          <ForwardObjectExplorerEvent Value="True" />
                                          <MatchingIndex Value="0" />
                                          <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.TextBox, OpenSpan.Adapters.Windows" />
                                          <Content Name="MatchRules">
                                            <Items>
                                              <OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Name="classNameMatchRule8" Id="ClassNameMatchRule-8D72AF5F0B4C433">
                                                <ClassName Value="Edit" />
                                              </OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule>
                                              <OpenSpan.Adapters.Windows.MatchRules.ControlIdMatchRule Name="controlIdMatchRule2" Id="ControlIdMatchRule-8D72AF5F0B727D2">
                                                <ControlId Value="1001" />
                                              </OpenSpan.Adapters.Windows.MatchRules.ControlIdMatchRule>
                                            </Items>
                                          </Content>
                                        </OpenSpan.Adapters.Controls.TextBox>
                                      </Items>
                                    </Content>
                                    <Content Name="MatchRules">
                                      <Items>
                                        <OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Name="classNameMatchRule7" Id="ClassNameMatchRule-8D72AF5F0ACB19E">
                                          <ClassName Value="ComboBox" />
                                        </OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule>
                                        <OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule Name="windowTextMatchRule3" Id="WindowTextMatchRule-8D72AF5F0B1776D">
                                          <Text Value="Simple|True|(User Culture)|*.txt" />
                                        </OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule>
                                      </Items>
                                    </Content>
                                  </OpenSpan.Adapters.Controls.ComboBox>
                                </Items>
                              </Content>
                              <Content Name="MatchRules">
                                <Items>
                                  <OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Name="classNameMatchRule6" Id="ClassNameMatchRule-8D72AF5F09FC4C9">
                                    <ClassName Value="FloatNotifySink" />
                                  </OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule>
                                  <OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule Name="windowTypeMatchRule3" Id="WindowTypeMatchRule-8D72AF5F0A588AC">
                                    <Type Value="Child" />
                                  </OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule>
                                </Items>
                              </Content>
                            </OpenSpan.Adapters.Controls.Control>
                          </Items>
                        </Content>
                        <Content Name="MatchRules">
                          <Items>
                            <OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Name="classNameMatchRule5" Id="ClassNameMatchRule-8D72AF5F0989E40">
                              <ClassName Value="DirectUIHWND" />
                            </OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule>
                            <OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule Name="windowTypeMatchRule2" Id="WindowTypeMatchRule-8D72AF5F09B005A">
                              <Type Value="Child" />
                            </OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule>
                          </Items>
                        </Content>
                      </OpenSpan.Adapters.Controls.Control>
                    </Items>
                  </Content>
                  <Content Name="MatchRules">
                    <Items>
                      <OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Name="classNameMatchRule4" Id="ClassNameMatchRule-8D72AF5F0779E5C">
                        <ClassName Value="DUIViewWndClassName" />
                      </OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule>
                      <OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule Name="windowTypeMatchRule1" Id="WindowTypeMatchRule-8D72AF5F0895024">
                        <Type Value="Child" />
                      </OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule>
                    </Items>
                  </Content>
                </OpenSpan.Adapters.Controls.Control>
                <OpenSpan.Adapters.Controls.Button Name="btnSave" Id="Button-8D72AF5F6F8A5EF">
                  <DummyPropertyToDetectReplaceUndo Value="0" />
                  <ForwardObjectExplorerEvent Value="True" />
                  <MatchingIndex Value="5" />
                  <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.Button, OpenSpan.Adapters.Windows" />
                  <Content Name="MatchRules">
                    <Items>
                      <OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule Name="windowTextMatchRule4" Id="WindowTextMatchRule-8D72AF5F6FD6A5E">
                        <Text Value="Simple|True|(User Culture)|&amp;Save" />
                      </OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule>
                      <OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Name="classNameMatchRule9" Id="ClassNameMatchRule-8D72AF5F71E63F2">
                        <ClassName Value="Button" />
                      </OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule>
                      <OpenSpan.Adapters.Windows.MatchRules.ControlIdMatchRule Name="controlIdMatchRule3" Id="ControlIdMatchRule-8D72AF5F73A9929">
                        <ControlId Value="1" />
                      </OpenSpan.Adapters.Windows.MatchRules.ControlIdMatchRule>
                    </Items>
                  </Content>
                </OpenSpan.Adapters.Controls.Button>
                <OpenSpan.Adapters.Controls.Button Name="btnCancel" Id="Button-8D72AF5F9F59E09">
                  <DummyPropertyToDetectReplaceUndo Value="0" />
                  <ForwardObjectExplorerEvent Value="True" />
                  <MatchingIndex Value="6" />
                  <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.Button, OpenSpan.Adapters.Windows" />
                  <Content Name="MatchRules">
                    <Items>
                      <OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule Name="windowTextMatchRule5" Id="WindowTextMatchRule-8D72AF5F9FA6278">
                        <Text Value="Simple|True|(User Culture)|Cancel" />
                      </OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule>
                      <OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Name="classNameMatchRule10" Id="ClassNameMatchRule-8D72AF5FA0E779E">
                        <ClassName Value="Button" />
                      </OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule>
                      <OpenSpan.Adapters.Windows.MatchRules.ControlIdMatchRule Name="controlIdMatchRule4" Id="ControlIdMatchRule-8D72AF5FA212439">
                        <ControlId Value="2" />
                      </OpenSpan.Adapters.Windows.MatchRules.ControlIdMatchRule>
                    </Items>
                  </Content>
                </OpenSpan.Adapters.Controls.Button>
              </Items>
            </Content>
            <Content Name="MatchRules">
              <Items>
                <OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule Name="windowTextMatchRule2" Id="WindowTextMatchRule-8D72AF5F049B800">
                  <Text Value="Simple|True|(User Culture)|Save As" />
                </OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule>
                <OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Name="classNameMatchRule3" Id="ClassNameMatchRule-8D72AF5F0602C54">
                  <ClassName Value="#32770" />
                </OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule>
              </Items>
            </Content>
          </OpenSpan.Adapters.Controls.Form>
        </Items>
      </Content>
    </OpenSpan.Adapters.Windows.WindowsAdapter>
  </Component>
</OpenSpanDesignDocument>