using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LogpushJob
{
    [JsiiByValue(fqn: "cloudflare.logpushJob.LogpushJobOutputOptions")]
    public class LogpushJobOutputOptions : cloudflare.LogpushJob.ILogpushJobOutputOptions
    {
        /// <summary>String to be prepended before each batch.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/logpush_job#batch_prefix LogpushJob#batch_prefix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "batchPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BatchPrefix
        {
            get;
            set;
        }

        /// <summary>String to be appended after each batch.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/logpush_job#batch_suffix LogpushJob#batch_suffix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "batchSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BatchSuffix
        {
            get;
            set;
        }

        private object? _cve202144228;

        /// <summary>If set to true, will cause all occurrences of `${` in the generated files to be replaced with `x{`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/logpush_job#cve_2021_44228 LogpushJob#cve_2021_44228}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cve202144228", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Cve202144228
        {
            get => _cve202144228;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cve202144228 = value;
            }
        }

        /// <summary>String to join fields. This field be ignored when `record_template` is set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/logpush_job#field_delimiter LogpushJob#field_delimiter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fieldDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FieldDelimiter
        {
            get;
            set;
        }

        /// <summary>List of field names to be included in the Logpush output.</summary>
        /// <remarks>
        /// For the moment, there is no option to add all fields at once, so you must specify all the fields names you are interested in.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/logpush_job#field_names LogpushJob#field_names}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fieldNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? FieldNames
        {
            get;
            set;
        }

        private object? _mergeSubrequests;

        /// <summary>If set to true, subrequests will be merged into the parent request. Only supported for the `http_requests` dataset.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/logpush_job#merge_subrequests LogpushJob#merge_subrequests}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mergeSubrequests", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? MergeSubrequests
        {
            get => _mergeSubrequests;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _mergeSubrequests = value;
            }
        }

        /// <summary>Specifies the output type, such as `ndjson` or `csv`.</summary>
        /// <remarks>
        /// This sets default values for the rest of the settings, depending on the chosen output type. Some formatting rules, like string quoting, are different between output types.
        /// Available values: "ndjson", "csv".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/logpush_job#output_type LogpushJob#output_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outputType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutputType
        {
            get;
            set;
        }

        /// <summary>String to be inserted in-between the records as separator.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/logpush_job#record_delimiter LogpushJob#record_delimiter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recordDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecordDelimiter
        {
            get;
            set;
        }

        /// <summary>String to be prepended before each record.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/logpush_job#record_prefix LogpushJob#record_prefix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recordPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecordPrefix
        {
            get;
            set;
        }

        /// <summary>String to be appended after each record.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/logpush_job#record_suffix LogpushJob#record_suffix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recordSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecordSuffix
        {
            get;
            set;
        }

        /// <summary>String to use as template for each record instead of the default json key value mapping.</summary>
        /// <remarks>
        /// All fields used in the template must be present in <c>field_names</c> as well, otherwise they will end up as null. Format as a Go <c>text/template</c> without any standard functions, like conditionals, loops, sub-templates, etc.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/logpush_job#record_template LogpushJob#record_template}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recordTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecordTemplate
        {
            get;
            set;
        }

        /// <summary>Floating number to specify sampling rate.</summary>
        /// <remarks>
        /// Sampling is applied on top of filtering, and regardless of the current <c>sample_interval</c> of the data.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/logpush_job#sample_rate LogpushJob#sample_rate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SampleRate
        {
            get;
            set;
        }

        /// <summary>String to specify the format for timestamps, such as `unixnano`, `unix`, `rfc3339`, `rfc3339ms` or `rfc3339ns`.</summary>
        /// <remarks>
        /// Available values: "unixnano", "unix", "rfc3339", "rfc3339ms", "rfc3339ns".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/logpush_job#timestamp_format LogpushJob#timestamp_format}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timestampFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimestampFormat
        {
            get;
            set;
        }
    }
}
