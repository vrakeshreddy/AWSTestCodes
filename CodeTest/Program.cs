﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

using CodeTest.AmazonEC2;
using CodeTest.AmazonS3;

namespace CodeTest
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            //Console.Write(GetServiceOutput());
           
            string buckName = "elasticbeanstalk-us-west-2-199824416412";
            AmazonS3.AmazonS3 s3 = new AmazonS3.AmazonS3();
            s3.DeleteBucket(buckName);

            Console.WriteLine("Done");
            Console.Read();

        }

        //public static string GetServiceOutput()
        //{
        //    StringBuilder sb = new StringBuilder(1024);
        //    using (StringWriter sr = new StringWriter(sb))
        //    {
        //        sr.WriteLine("===========================================");
        //        sr.WriteLine("Welcome to the AWS .NET SDK!");
        //        sr.WriteLine("===========================================");

        //        // Print the number of Amazon EC2 instances.
        //        IAmazonEC2 ec2 = new AmazonEC2Client();
        //        DescribeInstancesRequest ec2Request = new DescribeInstancesRequest();

        //        try
        //        {
        //            DescribeInstancesResponse ec2Response = ec2.DescribeInstances(ec2Request);
        //            int numInstances = 0;
        //            numInstances = ec2Response.Reservations.Count;
        //            sr.WriteLine(string.Format("You have {0} Amazon EC2 instance(s) running in the {1} region.",
        //                                       numInstances, ConfigurationManager.AppSettings["AWSRegion"]));
        //        }
        //        catch (AmazonEC2Exception ex)
        //        {
        //            if (ex.ErrorCode != null && ex.ErrorCode.Equals("AuthFailure"))
        //            {
        //                sr.WriteLine("The account you are using is not signed up for Amazon EC2.");
        //                sr.WriteLine("You can sign up for Amazon EC2 at http://aws.amazon.com/ec2");
        //            }
        //            else
        //            {
        //                sr.WriteLine("Caught Exception: " + ex.Message);
        //                sr.WriteLine("Response Status Code: " + ex.StatusCode);
        //                sr.WriteLine("Error Code: " + ex.ErrorCode);
        //                sr.WriteLine("Error Type: " + ex.ErrorType);
        //                sr.WriteLine("Request ID: " + ex.RequestId);
        //            }
        //        }
        //        sr.WriteLine();

        //        // Print the number of Amazon SimpleDB domains.
        //        IAmazonSimpleDB sdb = new AmazonSimpleDBClient();
        //        ListDomainsRequest sdbRequest = new ListDomainsRequest();

        //        try
        //        {
        //            ListDomainsResponse sdbResponse = sdb.ListDomains(sdbRequest);

        //            int numDomains = 0;
        //            numDomains = sdbResponse.DomainNames.Count;
        //            sr.WriteLine(string.Format("You have {0} Amazon SimpleDB domain(s) in the {1} region.",
        //                                       numDomains, ConfigurationManager.AppSettings["AWSRegion"]));
        //        }
        //        catch (AmazonSimpleDBException ex)
        //        {
        //            if (ex.ErrorCode != null && ex.ErrorCode.Equals("AuthFailure"))
        //            {
        //                sr.WriteLine("The account you are using is not signed up for Amazon SimpleDB.");
        //                sr.WriteLine("You can sign up for Amazon SimpleDB at http://aws.amazon.com/simpledb");
        //            }
        //            else
        //            {
        //                sr.WriteLine("Caught Exception: " + ex.Message);
        //                sr.WriteLine("Response Status Code: " + ex.StatusCode);
        //                sr.WriteLine("Error Code: " + ex.ErrorCode);
        //                sr.WriteLine("Error Type: " + ex.ErrorType);
        //                sr.WriteLine("Request ID: " + ex.RequestId);
        //            }
        //        }
        //        sr.WriteLine();

        //        // Print the number of Amazon S3 Buckets.
        //        IAmazonS3 s3Client = new AmazonS3Client();

        //        try
        //        {
        //            ListBucketsResponse response = s3Client.ListBuckets();
        //            int numBuckets = 0;
        //            if (response.Buckets != null &&
        //                response.Buckets.Count > 0)
        //            {
        //                numBuckets = response.Buckets.Count;
        //            }
        //            sr.WriteLine("You have " + numBuckets + " Amazon S3 bucket(s).");
        //        }
        //        catch (AmazonS3Exception ex)
        //        {
        //            if (ex.ErrorCode != null && (ex.ErrorCode.Equals("InvalidAccessKeyId") ||
        //                ex.ErrorCode.Equals("InvalidSecurity")))
        //            {
        //                sr.WriteLine("Please check the provided AWS Credentials.");
        //                sr.WriteLine("If you haven't signed up for Amazon S3, please visit http://aws.amazon.com/s3");
        //            }
        //            else
        //            {
        //                sr.WriteLine("Caught Exception: " + ex.Message);
        //                sr.WriteLine("Response Status Code: " + ex.StatusCode);
        //                sr.WriteLine("Error Code: " + ex.ErrorCode);
        //                sr.WriteLine("Request ID: " + ex.RequestId);
        //            }
        //        }
        //        sr.WriteLine("Press any key to continue...");
        //    }
        //    return sb.ToString();
        //}

        //public static void GetS3Instances()
        //{
        //    AmazonS3Client clientS3 = new AmazonS3Client();

        //    PutBucketRequest request = new PutBucketRequest();
        //    Console.WriteLine("step 1");
        //    request.BucketName = "bucketabc2016";
        //    Console.WriteLine("step 2");
        //    request.UseClientRegion = true;
        //    Console.WriteLine("step 3");
        //    PutBucketResponse putBucket = clientS3.PutBucket(request);
        //    Console.WriteLine("step 4");

        //    //DeleteBucketRequest delRequest = new DeleteBucketRequest();
        //    //delRequest.BucketName = "bucketabc2016";
        //    //delRequest.UseClientRegion = true;

        //    //DeleteBucketResponse delResponse = clientS3.DeleteBucketRequest(delRequest);

        //}

        //public static void DeleteBucket()
        //{
        //    AmazonS3Client clientS3 = new AmazonS3Client();
        //    Console.WriteLine("Steppp");
        //    clientS3.DeleteBucket("bucketabc2016");
        //}


    }
}
