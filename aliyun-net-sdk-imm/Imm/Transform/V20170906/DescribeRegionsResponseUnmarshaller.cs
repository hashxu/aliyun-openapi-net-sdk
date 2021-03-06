/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class DescribeRegionsResponseUnmarshaller
    {
        public static DescribeRegionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRegionsResponse describeRegionsResponse = new DescribeRegionsResponse();

			describeRegionsResponse.HttpResponse = context.HttpResponse;
			describeRegionsResponse.RequestId = context.StringValue("DescribeRegions.RequestId");

			List<DescribeRegionsResponse.DescribeRegions_RegionsItem> describeRegionsResponse_regions = new List<DescribeRegionsResponse.DescribeRegions_RegionsItem>();
			for (int i = 0; i < context.Length("DescribeRegions.Regions.Length"); i++) {
				DescribeRegionsResponse.DescribeRegions_RegionsItem regionsItem = new DescribeRegionsResponse.DescribeRegions_RegionsItem();
				regionsItem.Region = context.StringValue("DescribeRegions.Regions["+ i +"].Region");
				regionsItem.Status = context.StringValue("DescribeRegions.Regions["+ i +"].Status");
				regionsItem.ShowName = context.StringValue("DescribeRegions.Regions["+ i +"].ShowName");

				describeRegionsResponse_regions.Add(regionsItem);
			}
			describeRegionsResponse.Regions = describeRegionsResponse_regions;
        
			return describeRegionsResponse;
        }
    }
}