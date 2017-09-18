import { IsusCoreFullNet2017SpaTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: IsusCoreFullNet2017SpaTemplatePage;

  beforeEach(() => {
    page = new IsusCoreFullNet2017SpaTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
