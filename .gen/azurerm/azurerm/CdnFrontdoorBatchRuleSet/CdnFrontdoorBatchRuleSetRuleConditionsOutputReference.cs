using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorBatchRuleSet
{
    [JsiiClass(nativeType: typeof(azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsOutputReference), fullyQualifiedName: "azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CdnFrontdoorBatchRuleSetRuleConditionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CdnFrontdoorBatchRuleSetRuleConditionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnFrontdoorBatchRuleSetRuleConditionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnFrontdoorBatchRuleSetRuleConditionsOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsClientPort" />)[]</param>
        [JsiiMethod(name: "putClientPort", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsClientPort\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutClientPort(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsClientPort[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsClientPort).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsClientPort).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsDeviceType" />)[]</param>
        [JsiiMethod(name: "putDeviceType", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsDeviceType\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDeviceType(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsDeviceType[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsDeviceType).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsDeviceType).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsHostName" />)[]</param>
        [JsiiMethod(name: "putHostName", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsHostName\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHostName(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsHostName[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsHostName).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsHostName).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsHttpVersion" />)[]</param>
        [JsiiMethod(name: "putHttpVersion", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsHttpVersion\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHttpVersion(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsHttpVersion[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsHttpVersion).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsHttpVersion).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsPostArgument" />)[]</param>
        [JsiiMethod(name: "putPostArgument", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsPostArgument\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPostArgument(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsPostArgument[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsPostArgument).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsPostArgument).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsQueryString" />)[]</param>
        [JsiiMethod(name: "putQueryString", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsQueryString\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutQueryString(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsQueryString[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsQueryString).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsQueryString).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRemoteAddress" />)[]</param>
        [JsiiMethod(name: "putRemoteAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRemoteAddress\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRemoteAddress(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRemoteAddress[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRemoteAddress).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRemoteAddress).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestBody" />)[]</param>
        [JsiiMethod(name: "putRequestBody", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestBody\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequestBody(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestBody[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestBody).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestBody).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestCookies" />)[]</param>
        [JsiiMethod(name: "putRequestCookies", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestCookies\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequestCookies(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestCookies[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestCookies).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestCookies).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestFileExtension" />)[]</param>
        [JsiiMethod(name: "putRequestFileExtension", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestFileExtension\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequestFileExtension(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestFileExtension[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestFileExtension).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestFileExtension).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestFilename" />)[]</param>
        [JsiiMethod(name: "putRequestFilename", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestFilename\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequestFilename(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestFilename[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestFilename).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestFilename).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestHeader" />)[]</param>
        [JsiiMethod(name: "putRequestHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestHeader\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequestHeader(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestHeader[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestHeader).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestHeader).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestMethod" />)[]</param>
        [JsiiMethod(name: "putRequestMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestMethod\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequestMethod(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestMethod[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestMethod).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestMethod).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestPath" />)[]</param>
        [JsiiMethod(name: "putRequestPath", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestPath\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequestPath(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestPath[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestPath).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestPath).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestScheme" />)[]</param>
        [JsiiMethod(name: "putRequestScheme", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestScheme\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequestScheme(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestScheme[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestScheme).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestScheme).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestUrl" />)[]</param>
        [JsiiMethod(name: "putRequestUrl", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestUrl\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequestUrl(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestUrl[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestUrl).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestUrl).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsServerPort" />)[]</param>
        [JsiiMethod(name: "putServerPort", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsServerPort\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutServerPort(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsServerPort[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsServerPort).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsServerPort).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsSocketAddress" />)[]</param>
        [JsiiMethod(name: "putSocketAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsSocketAddress\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSocketAddress(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsSocketAddress[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsSocketAddress).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsSocketAddress).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsSslProtocol" />)[]</param>
        [JsiiMethod(name: "putSslProtocol", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsSslProtocol\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSslProtocol(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsSslProtocol[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsSslProtocol).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsSslProtocol).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClientPort")]
        public virtual void ResetClientPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeviceType")]
        public virtual void ResetDeviceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostName")]
        public virtual void ResetHostName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpVersion")]
        public virtual void ResetHttpVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPostArgument")]
        public virtual void ResetPostArgument()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryString")]
        public virtual void ResetQueryString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRemoteAddress")]
        public virtual void ResetRemoteAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestBody")]
        public virtual void ResetRequestBody()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestCookies")]
        public virtual void ResetRequestCookies()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestFileExtension")]
        public virtual void ResetRequestFileExtension()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestFilename")]
        public virtual void ResetRequestFilename()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestHeader")]
        public virtual void ResetRequestHeader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestMethod")]
        public virtual void ResetRequestMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestPath")]
        public virtual void ResetRequestPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestScheme")]
        public virtual void ResetRequestScheme()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestUrl")]
        public virtual void ResetRequestUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerPort")]
        public virtual void ResetServerPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSocketAddress")]
        public virtual void ResetSocketAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSslProtocol")]
        public virtual void ResetSslProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "clientPort", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsClientPortList\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsClientPortList ClientPort
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsClientPortList>()!;
        }

        [JsiiProperty(name: "deviceType", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsDeviceTypeList\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsDeviceTypeList DeviceType
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsDeviceTypeList>()!;
        }

        [JsiiProperty(name: "hostName", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsHostNameList\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsHostNameList HostName
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsHostNameList>()!;
        }

        [JsiiProperty(name: "httpVersion", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsHttpVersionList\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsHttpVersionList HttpVersion
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsHttpVersionList>()!;
        }

        [JsiiProperty(name: "postArgument", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsPostArgumentList\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsPostArgumentList PostArgument
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsPostArgumentList>()!;
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsQueryStringList\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsQueryStringList QueryString
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsQueryStringList>()!;
        }

        [JsiiProperty(name: "remoteAddress", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRemoteAddressList\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRemoteAddressList RemoteAddress
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRemoteAddressList>()!;
        }

        [JsiiProperty(name: "requestBody", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestBodyList\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestBodyList RequestBody
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestBodyList>()!;
        }

        [JsiiProperty(name: "requestCookies", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestCookiesList\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestCookiesList RequestCookies
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestCookiesList>()!;
        }

        [JsiiProperty(name: "requestFileExtension", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestFileExtensionList\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestFileExtensionList RequestFileExtension
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestFileExtensionList>()!;
        }

        [JsiiProperty(name: "requestFilename", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestFilenameList\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestFilenameList RequestFilename
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestFilenameList>()!;
        }

        [JsiiProperty(name: "requestHeader", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestHeaderList\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestHeaderList RequestHeader
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestHeaderList>()!;
        }

        [JsiiProperty(name: "requestMethod", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestMethodList\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestMethodList RequestMethod
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestMethodList>()!;
        }

        [JsiiProperty(name: "requestPath", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestPathList\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestPathList RequestPath
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestPathList>()!;
        }

        [JsiiProperty(name: "requestScheme", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestSchemeList\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestSchemeList RequestScheme
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestSchemeList>()!;
        }

        [JsiiProperty(name: "requestUrl", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestUrlList\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestUrlList RequestUrl
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestUrlList>()!;
        }

        [JsiiProperty(name: "serverPort", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsServerPortList\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsServerPortList ServerPort
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsServerPortList>()!;
        }

        [JsiiProperty(name: "socketAddress", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsSocketAddressList\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsSocketAddressList SocketAddress
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsSocketAddressList>()!;
        }

        [JsiiProperty(name: "sslProtocol", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsSslProtocolList\"}")]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsSslProtocolList SslProtocol
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsSslProtocolList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsClientPort" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientPortInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsClientPort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ClientPortInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsDeviceType" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deviceTypeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsDeviceType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DeviceTypeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsHostName" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsHostName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HostNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsHttpVersion" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpVersionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsHttpVersion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HttpVersionInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsPostArgument" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "postArgumentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsPostArgument\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PostArgumentInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsQueryString" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryStringInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? QueryStringInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRemoteAddress" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "remoteAddressInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRemoteAddress\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RemoteAddressInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestBody" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestBodyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestBody\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequestBodyInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestCookies" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestCookiesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestCookies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequestCookiesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestFileExtension" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestFileExtensionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestFileExtension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequestFileExtensionInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestFilename" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestFilenameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestFilename\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequestFilenameInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestHeader" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestHeaderInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequestHeaderInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestMethod" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestMethodInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestMethod\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequestMethodInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestPath" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestPathInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequestPathInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestScheme" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestSchemeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestScheme\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequestSchemeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsRequestUrl" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestUrlInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsRequestUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequestUrlInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsServerPort" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serverPortInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsServerPort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ServerPortInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsSocketAddress" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "socketAddressInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsSocketAddress\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SocketAddressInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditionsSslProtocol" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sslProtocolInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditionsSslProtocol\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SslProtocolInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorBatchRuleSet.CdnFrontdoorBatchRuleSetRuleConditions\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditions? InternalValue
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorBatchRuleSet.ICdnFrontdoorBatchRuleSetRuleConditions?>();
            set => SetInstanceProperty(value);
        }
    }
}
